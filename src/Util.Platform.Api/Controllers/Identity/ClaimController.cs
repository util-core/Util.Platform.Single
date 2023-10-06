namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 声明控制器
/// </summary>
[Acl( "claim.view" )]
public class ClaimController : CrudControllerBase<ClaimDto, ClaimQuery> {
    /// <summary>
    /// 初始化声明控制器
    /// </summary>
    /// <param name="service">声明服务</param>
    public ClaimController( IClaimService service ) : base( service ) {
        ClaimService = service;
    }

    /// <summary>
    /// 声明服务
    /// </summary>
    protected IClaimService ClaimService { get; }

    /// <summary>
    /// 获取单个实体
    /// </summary>
    /// <param name="id">标识</param>
    [HttpGet( "{id}" )]
    public new async Task<IActionResult> GetAsync( string id ) {
        return await base.GetAsync( id );
    }

    /// <summary>
    /// 分页查询
    /// </summary>
    /// <param name="query">查询参数</param>
    [HttpGet]
    public new async Task<IActionResult> PageQueryAsync( [FromQuery] ClaimQuery query ) {
        return await base.PageQueryAsync( query );
    }

    /// <summary>
    /// 获取项列表
    /// </summary>
    [HttpGet( "Items" )]
    public async Task<IActionResult> GetItemsAsync() {
        var list = await ClaimService.GetEnabledClaimsAsync();
        var result = list.Select( t => new Item( t.Name, t.Name ) );
        return Success( result );
    }

    /// <summary>
    /// 批量保存
    /// </summary>
    /// <param name="request">保存参数</param>
    [HttpPost( "save" )]
    [Acl( "claim.save" )]
    public new async Task<IActionResult> SaveAsync( SaveModel request ) {
        return await base.SaveAsync( request );
    }
}