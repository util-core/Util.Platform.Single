namespace Util.Platform.Api.Controllers;

/// <summary>
/// 系统控制器
/// </summary>
public class SystemController : WebApiControllerBase
{
    /// <summary>
    /// 初始化系统控制器
    /// </summary>
    /// <param name="service">系统服务</param>
    public SystemController(ISystemService service)
    {
        SystemService = service ?? throw new ArgumentNullException(nameof(service));
    }

    /// <summary>
    /// 系统服务
    /// </summary>
    protected ISystemService SystemService { get; }

    /// <summary>
    /// 退出登录
    /// </summary>
    [HttpGet("Logout")]
    [AllowAnonymous]
    public async Task<IActionResult> Logout()
    {
        await SystemService.SignOutAsync();
        return Success();
    }
}