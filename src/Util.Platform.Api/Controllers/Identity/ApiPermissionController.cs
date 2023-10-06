namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// Api权限控制器
/// </summary>
[Acl( "permission.view" )]
public class ApiPermissionController : WebApiControllerBase {
    /// <summary>
    /// 初始化Api权限控制器
    /// </summary>
    /// <param name="service">Api权限服务</param>
    public ApiPermissionController( IApiPermissionService service ) {
        ApiPermissionService = service;
    }

    /// <summary>
    /// Api权限服务
    /// </summary>
    protected IApiPermissionService ApiPermissionService { get; }

    /// <summary>
    /// 加载Api权限
    /// </summary>
    /// <param name="query">查询参数</param>
    [HttpGet]
    public async Task<IActionResult> LoadAsync( [FromQuery] PermissionQuery query ) {
        if ( query.ApplicationId.IsEmpty() )
            throw new InvalidOperationException( "应用程序标识未设置" );
        if ( query.RoleId.IsEmpty() )
            throw new InvalidOperationException( "角色标识未设置" );
        var operations = await ApiPermissionService.GetApisAsync( query.ApplicationId.SafeValue(), query.RoleId.SafeValue(), query.IsDeny.SafeValue() );
        var result = new TreeTableResult<ApiResourceDto>( operations, false, true ).GetResult();
        return Success( result );
    }

    /// <summary>
    /// 授予Api权限
    /// </summary>
    /// <param name="request">权限参数</param>
    [HttpPost( "GrantPermissions" )]
    [Acl( "permission.grantApi" )]
    public async Task<IActionResult> GrantPermissionsAsync( PermissionRequest request ) {
        await ApiPermissionService.GrantApiPermissionsAsync( request );
        return Success();
    }

    /// <summary>
    /// 拒绝Api权限
    /// </summary>
    /// <param name="request">权限参数</param>
    [HttpPost( "DenyPermissions" )]
    [Acl( "permission.denyApi" )]
    public async Task<IActionResult> DenyPermissionsAsync( PermissionRequest request ) {
        await ApiPermissionService.DenyApiPermissionsAsync( request );
        return Success();
    }
}