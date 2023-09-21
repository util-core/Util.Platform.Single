namespace Util.Platform.Api.Controllers;

/// <summary>
/// 权限控制器
/// </summary>
public class PermissionController : WebApiControllerBase {
    /// <summary>
    /// 初始化权限控制器
    /// </summary>
    /// <param name="service">权限服务</param>
    public PermissionController( IPermissionService service ) {
        PermissionService = service ?? throw new ArgumentNullException( nameof( service ) );
    }

    /// <summary>
    /// 权限服务
    /// </summary>
    protected IPermissionService PermissionService { get; }

    /// <summary>
    /// 获取授予用户的前端应用资源
    /// </summary>
    [HttpGet( "AppResources" )]
    public async Task<IActionResult> GetAppResourcesAsync() {
        var result = await PermissionService.GetAppResourcesAsync( Session.GetApplicationId(), Session.GetUserId() );
        return Success( result );
    }
}