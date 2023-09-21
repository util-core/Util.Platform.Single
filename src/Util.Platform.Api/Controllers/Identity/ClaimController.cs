namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 声明控制器
/// </summary>
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
    /// 查询
    /// </summary>
    /// <param name="query">查询参数</param>
    [HttpGet( "Query" )]
    public new async Task<IActionResult> QueryAsync( [FromQuery] ClaimQuery query ) {
        return await base.QueryAsync( query );
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
    /// 创建
    /// </summary>
    /// <param name="request">创建参数</param>
    [HttpPost]
    public new async Task<IActionResult> CreateAsync( ClaimDto request ) {
        return await base.CreateAsync( request );
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="id">标识</param>
    /// <param name="request">修改参数</param>
    [HttpPut( "{id?}" )]
    public new async Task<IActionResult> UpdateAsync( string id, ClaimDto request ) {
        return await base.UpdateAsync( id, request );
    }

    /// <summary>
    /// 批量删除
    /// </summary>
    /// <param name="ids">标识列表，多个Id用逗号分隔，范例：1,2,3</param>
    [HttpPost( "delete" )]
    public new async Task<IActionResult> DeleteAsync( [FromBody] string ids ) {
        return await base.DeleteAsync( ids );
    }

    /// <summary>
    /// 批量保存
    /// </summary>
    /// <param name="request">保存参数</param>
    [HttpPost( "save" )]
    public new async Task<IActionResult> SaveAsync( SaveModel request ) {
        return await base.SaveAsync( request );
    }
}