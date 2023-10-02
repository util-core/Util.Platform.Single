namespace Util.Platform.Api.Controllers;

/// <summary>
/// 主控制器
/// </summary>
[AllowAnonymous]
public class HomeController : HomeControllerBase {
    /// <summary>
    /// 初始化主控制器
    /// </summary>
    /// <param name="interaction">交互服务</param>
    /// <param name="environment">主机环境</param>
    public HomeController( IIdentityServerInteractionService interaction, IWebHostEnvironment environment ) 
        : base( interaction, environment ) {
    }
}