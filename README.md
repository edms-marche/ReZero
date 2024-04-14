# 一、ReZero说明
是一款.NET中间件,让你无需写任何代码也能实现CRUD，也可以发布成exe独立使用于非.NET用户


# 二、功能介绍
在线数据库和表
在线创建API接口 、接口文档 和接口调试


 
# 三、非.NET用户下载EXE运行
https://gitee.com/sunkaixuan/ReZero/releases/tag/1.0.0.16


# 四、.NET用户教程

## 4.1 Nuget安装
```cs
Rezero.Api 
``` 
## 4.2 一行代码配置
新建一个.NET6+ WEB API
只需要注入一行代码就能使用 Rezero API

```cs
/***对现有代码没有任何影响***/

//注册：注册超级API服务
builder.Services.AddReZeroServices(api =>
{
    //启用超级API
    api.EnableSuperApi();//默认载体为sqlite ，有重载可以配置数据库

});
//写在builder.Build前面就行只需要一行
var app = builder.Build();

```
## 4.3使用ReZero
启动项目直接访问地址就行了
http://localhost:5267/rezero 
 
## 4.4功能预览

![输入图片说明](image2.png)![输入图片说明](QQ%E6%88%AA%E5%9B%BE20240414121043.png)