namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 身份资源控制器
/// </summary>
public class IdentityResourceController : QueryControllerBase<IdentityResourceDto, ResourceQuery> {
    /// <summary>
    /// 初始化身份资源控制器
    /// </summary>
    /// <param name="service">身份资源服务</param>
    public IdentityResourceController( IIdentityResourceService service ) : base( service ) {
        IdentityResourceService = service;
    }

    /// <summary>
    /// 身份资源服务
    /// </summary>
    protected IIdentityResourceService IdentityResourceService { get; }

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
    public new async Task<IActionResult> PageQueryAsync( [FromQuery] ResourceQuery query ) {
        return await base.PageQueryAsync( query );
    }

    /// <summary>
    /// 创建
    /// </summary>
    /// <param name="request">创建参数</param>
    [HttpPost]
    public async Task<IActionResult> CreateAsync( IdentityResourceDto request ) {
        if ( request == null )
            return Fail( ApplicationResource.CreateRequestIsEmpty );
        var id = await IdentityResourceService.CreateAsync( request );
        var result = await IdentityResourceService.GetByIdAsync( id );
        return Success( result );
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="id">标识</param>
    /// <param name="request">修改参数</param>
    [HttpPut( "{id?}" )]
    public async Task<IActionResult> UpdateAsync( string id, IdentityResourceDto request ) {
        if ( request == null )
            return Fail( ApplicationResource.UpdateRequestIsEmpty );
        if ( id.IsEmpty() && request.Id.IsEmpty() )
            return Fail( ApplicationResource.IdIsEmpty );
        if ( request.Id.IsEmpty() )
            request.Id = id;
        await IdentityResourceService.UpdateAsync( request );
        var result = await IdentityResourceService.GetByIdAsync( request.Id );
        return Success( result );
    }

    /// <summary>
    /// 批量删除
    /// </summary>
    /// <param name="ids">标识列表，多个Id用逗号分隔，范例：1,2,3</param>
    [HttpPost( "delete" )]
    public async Task<IActionResult> DeleteAsync( [FromBody] string ids ) {
        await IdentityResourceService.DeleteAsync( ids );
        return Success();
    }
}