# ChatGLM-6B 桌面对话环境一键整合包

## 功能

基于ChatGLM项目开发的本地聊天对话生成软件，支持中英文实时聊天，流模式，参数调整，量化/多卡模式启动 等基本功能。

![](intro3.gif)

## 使用方法

**首先安装Cuda12.1的驱动与Cudnn12的驱动**

然后以后直接运行，ChatGLMClient.exe


## 引用项目

本项目基于以下开源项目：

1) ChatGLM-6B
https://github.com/THUDM/ChatGLM-6B
这是本程序的核心部分，由清华大学 KEG 实验室和智谱 AI 公司开发，是目前国内性能最好的开源大语言模型

2) ChatGLM-Client
https://github.com/littlestone0806/ChatGLM-Client
这是本程序编写最重要参考的项目，littlestone大佬的程序可读性很强，从代码中受益（抄袭）良多

3) NetWinformControl
https://github.com/kwwwvagaa/NetWinformControl
这是本程序使用的UI库，kwwwvagaa大佬不仅技术牛，且非常幽默，五星推荐他写的这个图形库

## 下载说明

**由于空间的原因，本目录中仅包含源文件部分，不包含模型文件及Python环境依赖，请 ✫Star后移步百度网盘下载完整的程序包，Cuda与Cudnn驱动也包含在内。
******

一键整合包

链接：
https://pan.baidu.com/s/1vcZWyQD4L4-o8b7Js8riBA?pwd=xjyo 


## 硬件要求

CPU主频3G以上，至少4核心，32G内存

推荐显卡方式使用，一般8G以上显存都可以运行int4的量化模式。对于性能有追求的朋友建议上24G显存的卡，最廉价的选择是Tesla P40 24G，目前售价900米，便宜量又足，就是需要DIY一个风扇。性价比目前比较好的是GTX3060 12G，可以跑int8量化模式，效果尚可，主要是显存大，还可以玩玩其他AI项目也不亏。 目前售价大概1500米；这卡竟然还能打3D游戏呢。

如果没有显卡的可以选择CPU方式，前提是你要有一颗强大的芯（CPU）。
如果你像我一样喜欢捣鼓，也可以搞两块12G的卡做负载均衡,这样可以跑fp16全精度推理，性价比还是可以的。

## 版权声明

本人基本上是法盲，对网上代码奉行不问出处，拿来就用。如果本程序有任何地方侵犯到了您的权益，请立即与我联系，我将马上纠正。至于我写的这个程序，就入乡随俗选个MIT版权好了，如果你拿去随便改改就用了，但不想跟人提起从哪看到的这个项目其实也没事。

## 特别关注

目前ChatGLM3已于前日正式发布在官方主页

https://github.com/THUDM/ChatGLM3

ChatGLM3具有更快的推理速度，更精确的回答，并支持原生工具链，作者正在365996研究，待调通后会更新尽快提供给大家，敬请期待...也欢迎您一同加入ChatGLM3的开发队伍。



## QQ群

如果使用中有任何问题，欢迎加QQ群：750817170一起研究，真不是我谦虚，其实我自己也不太会。所以遇到问题只能是群策群力一起解决啦。就这样吧，最后谢谢大佬你读到这，真有耐心。

