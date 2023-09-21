namespace Util.Platform.Api.Controllers;

/// <summary>
/// Api资源控制器
/// </summary>
public class ApiResourceController : NgZorroTreeControllerBase<ApiResourceDto, CreateApiResourceRequest, ApiResourceDto, ResourceQuery> {
    /// <summary>
    /// 初始化Api资源控制器
    /// </summary>
    /// <param name="service">Api资源服务</param>
    public ApiResourceController( IApiResourceService service ) : base( service ) {
        ApiResourceService = service;
    }

    /// <summary>
    /// Api资源服务
    /// </summary>
    protected IApiResourceService ApiResourceService { get; }

    /// <summary>
    /// 获取单个实体
    /// </summary>
    /// <param name="id">标识</param>
    [HttpGet( "{id}" )]
    public new async Task<IActionResult> GetAsync( string id ) {
        var result = await base.GetAsync( id );
        return result;
    }

    /// <summary>
    /// 树形表格查询
    /// </summary>
    /// <param name="query">查询参数</param>
    [HttpGet]
    public new async Task<IActionResult> QueryAsync( [FromQuery] ResourceQuery query ) {
        return await base.QueryAsync( query );
    }

    /// <summary>
    /// 树形查询
    /// </summary>
    /// <param name="query">查询参数</param>
    [HttpGet( "tree" )]
    public new async Task<IActionResult> TreeQueryAsync( [FromQuery] ResourceQuery query ) {
        return await base.TreeQueryAsync( query );
    }

    /// <summary>
    /// 创建Api资源
    /// </summary>
    /// <param name="request">创建参数</param>
    [HttpPost]
    public new async Task<IActionResult> CreateAsync( CreateApiResourceRequest request ) {
        if ( request == null )
            return Fail( ApplicationResource.CreateRequestIsEmpty );
        var id = await ApiResourceService.CreateAsync( request );
        var result = await ApiResourceService.GetByIdAsync( id );
        return Success( result );
    }

    /// <summary>
    /// 修改Api资源
    /// </summary>
    /// <param name="id">标识</param>
    /// <param name="request">修改参数</param>
    [HttpPut( "{id?}" )]
    public new async Task<IActionResult> UpdateAsync( string id, ApiResourceDto request ) {
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
    /// 启用
    /// </summary>
    /// <param name="ids">标识列表</param>
    [HttpPost( "enable" )]
    public new async Task<IActionResult> EnableAsync( [FromBody] string ids ) {
        return await base.EnableAsync( ids );
    }

    /// <summary>
    /// 禁用
    /// </summary>
    /// <param name="ids">标识列表</param>
    [HttpPost( "disable" )]
    public new async Task<IActionResult> DisableAsync( [FromBody] string ids ) {
        return await base.DisableAsync( ids );
    }
}