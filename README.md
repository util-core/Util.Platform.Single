[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://mit-license.org/)

<a href="https://www.jetbrains.com/?from=Util" target="_blank">
    <img src="https://github.com/dotnetcore/Home/blob/master/img/jetbrains.svg" title="JetBrains" />
</a>

## Util平台介绍

Util应用框架是一组类库,它们提供了有用的功能.

虽然Util配套代码生成器能够帮助你创建项目基架,但直接使用它们的成本依然高昂.

第一个挡在前面的障碍是权限功能,它是任何业务项目的基石.

为了减轻使用Util应用框架的负担,我们创建了该项目, 名为 **Util Platform**, 即 Util平台.

Util平台处于起步阶段,目前提供了基于资源和角色的权限模块,可以控制前端菜单和按钮,并能同时控制API的访问.

后续将持续更新,添加更多基础功能.

### 开源协议: MIT

可以在商业项目随意使用.

### 欢迎参与贡献

你如果感兴趣,可以参与该项目的开发, 共同创建基础业务功能,为 .NET 生态添砖加瓦.

- Util应用框架交流QQ群(24791014)

## Util平台项目介绍

为了满足**单体架构**和**微服务架构**的需求, Util平台分为三套项目.

- [Util.Platform.Single](https://github.com/util-core/Util.Platform.Single)

  Util.Platform.Single 是Util平台单体架构版本.
- [Util.Platform.Dapr](https://github.com/util-core/Util.Platform.Dapr)

  Util.Platform.Dapr 是Util平台微服务架构版本.
- [Util.Platform.Share](https://github.com/util-core/Util.Platform.Share)

  Util.Platform.Share 是Util平台的共享库,抽取单体架构版本和微服务架构版本的共享代码,并发布到Nuget供两个版本使用.

## Util平台功能列表

- ### 系统功能
  - 登录
  - 退出登录

- ### 权限管理模块
  - 应用程序管理
  - 声明管理
  - 资源管理
    - 模块资源管理
    - 操作资源管理
    - 身份资源管理
    - Api资源管理
  - 用户管理
  - 角色管理
    - 将用户添加到角色
    - 从角色移除用户
  - 权限管理
    - 授予角色操作权限
    - 拒绝角色操作权限
    - 授予角色API权限
    - 拒绝角色API权限

## Nuget包

| 包名 |  版本 | 下载量
|--------------|  ------- | ----
| Util.Platform.Share.Apps | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Apps.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Apps.svg)
| Util.Platform.Share.Infrastructure | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Infrastructure.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Infrastructure.svg)
| Util.Platform.Share.Middlewares | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Middlewares.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Middlewares.svg)
| Util.Platform.Share.Tools | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Tools.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Tools.svg)
| Util.Platform.Share.Ui.TagHelper | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Ui.TagHelper.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Ui.TagHelper.svg)
| Util.Platform.Share.Identity.Application | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Identity.Application.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Identity.Application.svg)
| Util.Platform.Share.Identity.Common | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Identity.Common.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Identity.Common.svg)
| Util.Platform.Share.Identity.Data | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Identity.Data.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Identity.Data.svg)
| Util.Platform.Share.Identity.Domain | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Identity.Domain.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Identity.Domain.svg)
| Util.Platform.Share.Identity.Dtos | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Identity.Dtos.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Identity.Dtos.svg)
| Util.Platform.Share.Identity.Queries | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Identity.Queries.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Identity.Queries.svg)
| Util.Platform.Share.Identity.IdentityServer | ![](https://img.shields.io/nuget/v/Util.Platform.Share.Identity.IdentityServer.svg) | ![](https://img.shields.io/nuget/dt/Util.Platform.Share.Identity.IdentityServer.svg)


## Npm包

| 包名 |  版本 | 下载量
|--------------|  ------- | ----
| util-platform | [![npm package](https://img.shields.io/npm/v/util-platform.svg?style=flat-square)](https://www.npmjs.org/package/util-platform) | [![NPM downloads](http://img.shields.io/npm/dm/util-platform.svg?style=flat-square)](https://npmjs.org/package/util-platform)
| util-platform-identity | [![npm package](https://img.shields.io/npm/v/util-platform-identity.svg?style=flat-square)](https://www.npmjs.org/package/util-platform-identity) | [![NPM downloads](http://img.shields.io/npm/dm/util-platform-identity.svg?style=flat-square)](https://npmjs.org/package/util-platform-identity)

