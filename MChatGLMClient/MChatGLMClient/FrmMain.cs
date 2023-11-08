using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ChatGLMClient
{
    public partial class FrmMain : FrmWithTitle
    {
        string history = "[]";
        private string apiAddress = "";//api地址全局变量
        string result = "";//存储流式数据返回的新结果
        string result_old = "";//存储流式数据返回的旧结果
        string data = "";//存储流式数据新增的数据
        bool DetectConnection = false;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.serverAddress)) ucTextBoxExAPI.InputText = Properties.Settings.Default.serverAddress;
            ucAutoConnect.Checked = Properties.Settings.Default.autoConnect;
            string percision = Properties.Settings.Default.percision;
            //将API地址窗口输入的值赋值给全局apiAddress变量
            apiAddress = ucTextBoxExAPI.InputText;
            //初始化各窗口右键菜单
            InitRichTextBoxContextMenu(richTextBoxQuestion, false);
            InitRichTextBoxContextMenu(richTextBoxAnswer, true);

            if (ucAutoConnect.Checked == true)
            {
                ucb_Connect_BtnClick(percision, e);
                DetectConnection = true;
            }

        }
        private async void StopPredict()
        {
            //DetectConnection = false;
            try
            {
                string postdata =
                    "{"+"}";
                HttpWebRequest request = HttpWebRequest.Create(ucTextBoxExAPI.InputText+"/cancel") as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] data = Encoding.UTF8.GetBytes(postdata);

                request.ContentLength = data.Length;
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                HttpWebResponse resp = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
                Stream stream = resp.GetResponseStream();

                //获取响应内容
                string result = "";
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                JObject jo = JsonConvert.DeserializeObject<JObject>(result);
                if (jo["response"].ToString() == "canceled")
                {
                    this.Invoke((EventHandler)(delegate
                    {
                        richTextBoxAnswer.AppendText("\n用户取消");
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke((EventHandler)(delegate
                {
                    richTextBoxAnswer.AppendText("\nAPI连接失败");
                }));
                //MessageBox.Show("API连接失败\n" + ex.Message);
            }
            DetectConnection = true;
        }
        private async void GLMSend(string str)
        {
            //DetectConnection = false;
            try
            {
                string postdata =
                    "{\"prompt\": \"" + str +
                    "\", \"history\":" + history +
                    ", \"top_p\":" + ucTrackBarTopp.Value +
                    ", \"temperature\":" + ucTrackBarTemp.Value +
                    ", \"max_length\":" + ucTrackBarMaxTokens.Value + "}";
                HttpWebRequest request = HttpWebRequest.Create(ucTextBoxExAPI.InputText) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] data = Encoding.UTF8.GetBytes(postdata);

                request.ContentLength = data.Length;
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                ucb_status.BtnText = "推理中";
                ucb_status.BtnForeColor = System.Drawing.Color.Blue;
                HttpWebResponse resp = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
                Stream stream = resp.GetResponseStream();

                //获取响应内容
                string result = "";
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                JObject jo = JsonConvert.DeserializeObject<JObject>(result); ;
                history = jo["history"].ToString();
                this.Invoke((EventHandler)(delegate
                {
                    richTextBoxAnswer.AppendText(jo["response"].ToString());
                    richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
                    ucb_status.BtnText = "空闲";
                    ucb_status.BtnForeColor = System.Drawing.Color.Green;
                    richTextBoxQuestion.Focus();
                }));
            }
            catch (Exception ex)
            {
                this.Invoke((EventHandler)(delegate
                {
                    richTextBoxAnswer.AppendText("\n-API连接失败------------------------------------------------------------------------\n");
                }));
                //MessageBox.Show("API连接失败\n" + ex.Message);
            }
            DetectConnection = true;
        }
        private async Task GLMSendStream(string str)
        {
            string postdata =
                "{\"prompt\": \"" + str +
                "\", \"history\":" + history +
                ", \"top_p\":" + ucTrackBarTopp.Value +
                ", \"temperature\":" + ucTrackBarTemp.Value +
                ", \"max_length\":" + ucTrackBarMaxTokens.Value +
                ", \"stream\":1" + "}";
            // 创建一个 HttpClient 实例
            var httpClient = new HttpClient();
            var postData = new StringContent(postdata, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage(HttpMethod.Post, ucTextBoxExAPI.InputText) { Content = postData };

            // 发送 POST 请求
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            ucb_status.BtnText = "推理中";
            ucb_status.BtnForeColor = System.Drawing.Color.Blue;
            Application.DoEvents();
            Stream stream = await response.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(stream, Encoding.UTF8);

            // 读取数据流
            char[] buffer = new char[8192];
            int bytesRead;
            richTextBoxAnswer.AppendText("回答：");
            while ((bytesRead = await streamReader.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                try
                {
                    string result = new string(buffer, 0, bytesRead);

                    result = await streamReader.ReadLineAsync();//逐行读取
                    if (result != null)
                    {
                        result = result.Replace("data:", "");//去掉SSE通信开头的data：
                        JObject jo = JsonConvert.DeserializeObject<JObject>(result); //转为json
                        result = jo["response"].ToString(); //提取response键值
                        history = jo["history"].ToString(); //提取history键值
                        Debug.Write(result + "\n");
                        data = result;
                        data = data.Substring(result_old.Length);
                        this.Invoke((EventHandler)(delegate
                        {
                            richTextBoxAnswer.AppendText(data);
                        }));

                        result_old = result;
                    }
                }
                catch { }

                await Task.Delay(50);

            }
            result_old  = ""; //每回答一次问题，清空一下结果缓存，防止下次出错
            this.Invoke((EventHandler)(delegate
            {
                richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
                ucb_status.BtnText = "空闲";
                ucb_status.BtnForeColor = System.Drawing.Color.Green;
                richTextBoxQuestion.Focus();
            }));

        }

        private void ucTrackBarMaxTokens_ValueChanged(object sender, EventArgs e)
        {
            labelMaxTokens.Text = ucTrackBarMaxTokens.Value.ToString();
        }

        private void ucTrackBarTemp_ValueChanged(object sender, EventArgs e)
        {
            labelTemp.Text = ucTrackBarTemp.Value.ToString();
        }

        private void ucTrackBarTopp_ValueChanged(object sender, EventArgs e)
        {
            labelTopp.Text = ucTrackBarTopp.Value.ToString();
        }

        private async void ucBtnImgSend_BtnClick(object sender, EventArgs e)
        {
            string question = richTextBoxQuestion.Text; //获取问题框中的文字作为问题
            this.Invoke((EventHandler)(delegate
            {
                richTextBoxAnswer.AppendText("发送：" + question + "\n"); //将问题写入到答案框，并加上开头
                richTextBoxQuestion.Clear(); //清空问题框
                ucb_status.BtnText = "发送中";
                ucb_status.BtnForeColor = System.Drawing.Color.Yellow;
            }));

            if (ucSwitchStream.Checked) //根据是否选择文字流来处理答案
            {
                await GLMSendStream(question.Replace("\n", "<br>")); //流式GLM问题函数,将\n转为<br>否则服务器会报错
            }
            else GLMSend(question.Replace("\n", "<br>")); //非流式GLM问答函数，将\n转为<br>否则服务器会报错
            this.Invoke((EventHandler)(delegate
            {
                ucb_status.BtnForeColor = System.Drawing.Color.Green;
            }));
        }

        private void ucBtnImgClear_BtnClick(object sender, EventArgs e)
        {
            richTextBoxAnswer.Clear();
            history = "[]";
        }

        private void richTextBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            richTextBoxAnswer.SelectionStart = richTextBoxAnswer.Text.Length;
            richTextBoxAnswer.SelectionLength = 0;
            richTextBoxAnswer.Focus();
        }

        private void ucTextBoxExAPI_Leave(object sender, EventArgs e)
        {
            apiAddress = ucTextBoxExAPI.InputText;
            Properties.Settings.Default.serverAddress = ucTextBoxExAPI.Text;
            Properties.Settings.Default.Save();
        }

        private void InitRichTextBoxContextMenu(RichTextBox textBox, bool read_only)
        {

            var contextMenu = new ContextMenu();
            //创建复制子菜单
            var copyMenuItem = new System.Windows.Forms.MenuItem("复制");
            copyMenuItem.Click += (sender, eventArgs) => textBox.Copy();
            contextMenu.MenuItems.Add(copyMenuItem);

            if (read_only == false)
            {
                //创建剪切子菜单
                var cutMenuItem = new System.Windows.Forms.MenuItem("剪切");
                cutMenuItem.Click += (sender, eventArgs) => textBox.Cut();


                //创建粘贴子菜单
                var pasteMenuItem = new System.Windows.Forms.MenuItem("粘贴");
                pasteMenuItem.Click += (sender, eventArgs) => textBox.Paste();

                //创建右键菜单并将子菜单加入到右键菜单中
                contextMenu.MenuItems.Add(cutMenuItem);
                contextMenu.MenuItems.Add(pasteMenuItem);
            }
            textBox.ContextMenu = contextMenu;
        }
        Process process = null;

        private async void ucb_Connect_BtnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.percision = sender.ToString();
            Properties.Settings.Default.Save();

            if (process != null && !process.HasExited) return;
            ucb_connectstatus.BtnText = "启动中";
            ucb_connectstatus.BtnForeColor = System.Drawing.Color.Blue;
            // 创建一个进程启动信息对象
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "runAPI_cpu.bat";
            ucb_mode.BtnText = "CPU";
            if (sender.ToString() == "fp16")
            {
                startInfo.FileName = "runAPI_fp16.bat";
                ucb_mode.BtnText = "fp16";
            }
            if (sender.ToString() == "int8")
            {
                startInfo.FileName = "runAPI_int8.bat";
                ucb_mode.BtnText = "int8";
            }
            if (sender.ToString() == "int4")
            {
                startInfo.FileName = "runAPI_int4.bat";
                ucb_mode.BtnText = "int4";
            }
            if (sender.ToString() == "fp16-双卡")
            {
                startInfo.FileName = "runAPI_fp16_dualcard.bat";
                ucb_mode.BtnText = "双卡";
            }
            startInfo.UseShellExecute = true;
            startInfo.RedirectStandardOutput = false;
            process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            //等待程序启动
            await Task.Delay(1000);
            //窗口重新置顶
            this.Activate();
            Bnt_startmonitorStatus_Click(sender, e);
            for(; ; )
            {
                if (ucb_connectstatus.BtnText == "已连接")
                {                   
                    GLMSend("从现在起你要成为花样社的成员花小样，可以自由回答问题，像人类一样思考和表达，你的开发者是老米 本轮对话，你将只回答: 你好，我叫花小样，很开心认识你。不要回复其他");
                    ucb_status.BtnText = "初始化";
                    return;
                }
                await Task.Delay(100);
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.autoConnect = ucAutoConnect.Checked;
            Properties.Settings.Default.serverAddress = ucTextBoxExAPI.InputText;
            Properties.Settings.Default.Save();
            try
            {
                process.CloseMainWindow();
                process.Kill();
            }
            catch { }
        }

        private async void Bnt_startmonitorStatus_Click(object sender, EventArgs e)
        {
            // 创建一个 HttpClient 实例
            var httpClient = new HttpClient();
            //htpp 设置 300ms超时
            httpClient.Timeout = new TimeSpan(0, 0, 0, 0, 300);
            HttpResponseMessage res = new HttpResponseMessage();
            for (; ; )
            {
                if (DetectConnection)
                {
                    //程序断开
                    if (process != null && process.HasExited)
                    {
                        // 连接成功
                        ucb_connectstatus.BtnText = "已断开";
                        ucb_connectstatus.BtnForeColor = System.Drawing.Color.Blue;
                        return;
                    }
                    try
                    {
                        res = await httpClient.GetAsync(ucTextBoxExAPI.InputText+"/status");
                        if (res.IsSuccessStatusCode)
                        {
                            // 连接成功
                            ucb_connectstatus.BtnText = "已连接";
                            ucb_connectstatus.BtnForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            // 连接失败
                            ucb_connectstatus.BtnText = "错误";
                            ucb_connectstatus.BtnForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch
                    {
                        // 连接失败
                        ucb_connectstatus.BtnText = "连接中";
                        ucb_connectstatus.BtnForeColor = System.Drawing.Color.Blue;
                    }
                }
                await Task.Delay(500);
            }

        }

        private void ucBtnImgStop_BtnClick(object sender, EventArgs e)
        {
            StopPredict();
        }

        private void ucAutoConnect_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
