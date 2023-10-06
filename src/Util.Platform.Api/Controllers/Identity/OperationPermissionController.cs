namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 操作权限控制器
/// </summary>
[Acl( "permission.view" )]
public class OperationPermissionController : WebApiControllerBase {
    /// <summary>
    /// 初始化操作权限控制器
    /// </summary>
    /// <param name="service">操作权限服务</param>
    public OperationPermissionController( IOperationPermissionService service ) {
        OperationPermissionService = service;
    }

    /// <summary>
    /// 操作权限服务
    /// </summary>
    protected IOperationPermissionService OperationPermissionService { get; }

    /// <summary>
    /// 加载操作权限
    /// </summary>
    /// <param name="query">查询参数</param>
    [HttpGet]
    public async Task<IActionResult> LoadAsync( [FromQuery] PermissionQuery query ) {
        if ( query.ApplicationId.IsEmpty() )
            throw new InvalidOperationException( "应用程序标识未设置" );
        if ( query.RoleId.IsEmpty() )
            throw new InvalidOperationException( "角色标识未设置" );
        var operations = await OperationPermissionService.GetOperationsAsync( query.ApplicationId.SafeValue(), query.RoleId.SafeValue(), query.IsDeny.SafeValue() );
        var result = new TreeTableResult<OperationPermissionDto>( operations, false, true ).GetResult();
        return Success( result );
    }

    /// <summary>
    /// 授予操作权限
    /// </summary>
    /// <param name="request">权限参数</param>
    [HttpPost( "GrantPermissions" )]
    [Acl( "permission.grantOperation" )]
    public async Task<IActionResult> GrantPermissionsAsync( PermissionRequest request ) {
        await OperationPermissionService.GrantOperationPermissionsAsync( request );
        return Success();
    }

    /// <summary>
    /// 拒绝操作权限
    /// </summary>
    /// <param name="request">权限参数</param>
    [HttpPost( "DenyPermissions" )]
    [Acl( "permission.denyOperation" )]
    public async Task<IActionResult> DenyPermissionsAsync( PermissionRequest request ) {
        await OperationPermissionService.DenyOperationPermissionsAsync( request );
        return Success();
    }
}