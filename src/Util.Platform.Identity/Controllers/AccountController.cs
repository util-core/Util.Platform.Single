namespace Util.Platform.Identity.Controllers; 

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
    public AccountController( IIdentityServerInteractionService interaction, IAuthenticationSchemeProvider schemeProvider, 
        IEventService events, ISystemService systemService  ) 
        : base( interaction, schemeProvider, events, systemService ) {
    }
}