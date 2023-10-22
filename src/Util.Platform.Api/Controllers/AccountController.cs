namespace Util.Platform.Api.Controllers;

/// <summary>
/// 用户认证控制器
/// </summary>
[AllowAnonymous]
public class AccountController : AccountControllerBase<ISystemService,LoginRequest> {
    /// <summary>
    /// 初始化用户认证控制器
    /// </summary>
    /// <param name="interaction">交互服务</param>
    /// <param name="schemeProvider">认证方案提供器</param>
    /// <param name="events">事件服务</param>
    /// <param name="systemService">系统服务</param>
    /// <param name="localizer">字符串本地化</param>
    public AccountController( IIdentityServerInteractionService interaction, IAuthenticationSchemeProvider schemeProvider, 
        IEventService events, ISystemService systemService,IStringLocalizer localizer  ) 
        : base( interaction, schemeProvider, events, systemService, localizer ) {
    }

    /// <summary>
    /// 退出登录
    /// </summary>
    [HttpGet]
    [Route( "/api/logout" )]
    public async Task Logout() {
        await SystemService.SignOutAsync();
    }
}