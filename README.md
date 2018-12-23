# A BarTender develope demo in C#

![image](https://raw.githubusercontent.com/ospanic/Bartender_Dev_Dome/master/run.png)

这是一个用c#语言编写的BarTender二次开发示例程序，展示了BarTender软件的部分功能。

使用前请先安装 BarTender 10.1 或更高版本的条码设计软件。

BarTender 10.1 版本的软件可点击此处[此处](https://ai-thinker.oss-cn-shenzhen.aliyuncs.com/SimpleBarPrinter%2FBarTender_10_1.rar)下载。

# 安装破解方法

1.双击软件安装包，一路NEXT完成安装。

2.将破解软件复制到Bartender的安装目录，默认安装目录如下图所示：

![image](https://raw.githubusercontent.com/ospanic/Bartender_Dev_Dome/master/kill.png)

3.双击破解补丁，点击PATCH按钮完成破解。

注意：BarTender 为收费软件，此破解教程进攻个人学习使用，请勿用于其他任何商业用途。

# 二次开发简介
二次开发须引用```UnityEngine.dll``` 和 ```Seagull.BarTender.Print.dll``` 这两个动态链接库文件。

并且软件还要以.NETFramework 2.0 兼容方式运行，*Demo.exe.config 文件配置如下：

	<?xml version="1.0"?>
	<configuration>
	  <startup useLegacyV2RuntimeActivationPolicy="true">
	    
	  <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0,Profile=Client"/></startup>
	</configuration>

具体的开发细节就自己去看代码吧！！！