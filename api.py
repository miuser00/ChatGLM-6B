from fastapi import FastAPI, Request
from transformers import AutoTokenizer, AutoModel
import uvicorn, json, datetime
import torch
from sse_starlette.sse import EventSourceResponse
from utils import load_model_on_gpus
from options import parser
import os
import logging
from starlette.responses import JSONResponse
import asyncio
import concurrent.futures

cmd_opts = parser.parse_args()

DEVICE = "cuda"
DEVICE_ID = "0"
CUDA_DEVICE = f"{DEVICE}:{DEVICE_ID}" if DEVICE_ID else DEVICE

CANCELFLAG = False

global status
status = "空闲"


def torch_gc():
    if torch.cuda.is_available():
        with torch.cuda.device(CUDA_DEVICE):
            torch.cuda.empty_cache()
            torch.cuda.ipc_collect()


app = FastAPI()


def predict_stream(tokenizer, prompt, history, max_length, top_p, temperature):
    for response, history in model.stream_chat(tokenizer, prompt, history, max_length=max_length, top_p=top_p,
                                               temperature=temperature):
        # 中断当前推理
        if CANCELFLAG:
            return torch_gc()

        now = datetime.datetime.now()
        time = now.strftime("%Y-%m-%d %H:%M:%S")
        yield json.dumps({
            'response': response,
            'history': history,
            'status': 200,
            'time': time
        })
    log = "[" + time + "] " + '\033[32mprompt\033[0m:' + prompt + '\033[31m    response\033[0m:' + response

    print('\033[32mINFO:     \033[0m' + log + '\033[32m infer OK\033[0m')
    global status
    status = "空闲"
    return torch_gc()


def predict(tokenizer, prompt, history, max_length, top_p, temperature):
    response, history = model.chat(tokenizer,
                                   prompt,
                                   history=history,
                                   max_length=max_length if max_length else 2048,
                                   top_p=top_p if top_p else 0.7,
                                   temperature=temperature if temperature else 0.95)
    now = datetime.datetime.now()
    time = now.strftime("%Y-%m-%d %H:%M:%S")
    answer = {
        "response": response,
        "history": history,
        "status": 200,
        "time": time
    }
    log = 'prompt: ' + prompt + '   response: ' + response
    print(log)
    torch_gc()
    global status
    status = "空闲"
    return answer


@app.get("/status")
async def root():
    return {"message": status}

@app.get("/getdevices")
async def get_devices():
    # 获取可用的CUDA设备数量
    num_devices = torch.cuda.device_count()

    devices = []
    for i in range(num_devices):
        device_name = torch.cuda.get_device_name(i)
        devices.append({"device_id": i, "device_name": device_name})

    return {"devices": devices}

@app.post("/")
async def create_item(request: Request):
    global model, tokenizer, CANCELFLAG
    CANCELFLAG = False
    json_post_raw = await request.json()
    json_post = json.dumps(json_post_raw)
    json_post_list = json.loads(json_post)
    prompt = json_post_list.get('prompt')
    history = json_post_list.get('history')
    max_length = json_post_list.get('max_length')
    top_p = json_post_list.get('top_p')
    temperature = json_post_list.get('temperature')
    stream = json_post_list.get('stream')
    global status
    status = "推理中"
    # if stream:
    #     res = predict_stream(tokenizer, prompt, history, max_length, top_p, temperature)
    #     return EventSourceResponse(res)
    # else:
    #     answer = predict(tokenizer, prompt, history, max_length, top_p, temperature)
    #     return answer
    if stream:
        loop = asyncio.get_event_loop()
        result = await loop.run_in_executor(None, predict_stream, tokenizer, prompt, history, max_length, top_p,
                                            temperature)
        return EventSourceResponse(content=result)
    else:
        loop = asyncio.get_event_loop()
        answer = await loop.run_in_executor(None, predict, tokenizer, prompt,  history, max_length, top_p,
                                            temperature)
        return JSONResponse(content=answer)


@app.post("/cancel")
async def cancel_predict(request: Request):
    global CANCELFLAG
    CANCELFLAG = True
    global status
    status = "空闲"
    return {
        'response': 'canceled'
    }


if __name__ == '__main__':

    if cmd_opts.cpu:
        model = model.float()
    else:
        if cmd_opts.precision == "cpu":
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = AutoModel.from_pretrained(cmd_opts.model_path, trust_remote_code=True).float()
        elif cmd_opts.precision == "fp16":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = load_model_on_gpus(cmd_opts.model_path, num_gpus=1)
        elif cmd_opts.precision == "fp16dual":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = load_model_on_gpus(cmd_opts.model_path, num_gpus=2)
        elif cmd_opts.precision == "int4":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = AutoModel.from_pretrained(cmd_opts.model_path, trust_remote_code=True).quantize(8).half().cuda()
        elif cmd_opts.precision == "int8":
            os.environ["CUDA_VISIBLE_DEVICES"] = cmd_opts.availablecard  # e.g. '1,"
            tokenizer = AutoTokenizer.from_pretrained(cmd_opts.model_path, trust_remote_code=True)
            model = AutoModel.from_pretrained(cmd_opts.model_path, trust_remote_code=True).quantize(8).half().cuda()
    model = model.eval()

    class DisableStatusLogFilter(logging.Filter):
        def filter(self, record: logging.LogRecord) -> bool:
            return "/status" not in (" ".join([str(s) for s in record.args]))
    logging.getLogger("uvicorn.access").addFilter(DisableStatusLogFilter())

    uvicorn.run(app, host='0.0.0.0', port=7860, workers=1, )
