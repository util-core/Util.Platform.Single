namespace Util.Platform.Api.Controllers;

/// <summary>
/// 应用控制器
/// </summary>
public class AppController : WebApiControllerBase {
    /// <summary>
    /// 初始化应用控制器
    /// </summary>
    /// <param name="service">系统服务</param>
    public AppController( IAppService service ) {
        AppService = service ?? throw new ArgumentNullException( nameof( service ) );
    }

    /// <summary>
    /// 前端应用服务
    /// </summary>
    protected IAppService AppService { get; }

    /// <summary>
    /// 获取应用数据
    /// </summary>
    [HttpGet( "AppData" )]
    [Acl( Ignore = true )]
    public async Task<IActionResult> GetAppData() {
        var result = await AppService.GetAppDataByCacheAsync( Session.GetApplicationId(), Session.GetUserId() );
        return Success( result );
    }
}