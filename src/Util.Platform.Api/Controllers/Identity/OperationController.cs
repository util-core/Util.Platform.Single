namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 操作资源控制器
/// </summary>
public class OperationController : QueryControllerBase<OperationDto, ResourceQuery> {
    /// <summary>
    /// 初始化操作资源控制器
    /// </summary>
    /// <param name="service">操作资源服务</param>
    public OperationController( IOperationService service ) : base( service ) {
        OperationService = service;
    }

    /// <summary>
    /// 操作资源服务
    /// </summary>
    protected IOperationService OperationService { get; }

    /// <summary>
    /// 获取单个实体
    /// </summary>
    /// <param name="id">标识</param>
    [HttpGet( "{id}" )]
    public new async Task<IActionResult> GetAsync( string id ) {
        return await base.GetAsync( id );
    }

    /// <summary>
    /// 获取操作关联的Api资源标识列表
    /// </summary>
    /// <param name="operationId">操作标识</param>
    [HttpGet( "getApiIds" )]
    public async Task<IActionResult> GetApiResourceIdsAsync( string operationId ) {
        if ( operationId.IsEmpty() )
            throw new ArgumentNullException( nameof( operationId ) );
        var result = await OperationService.GetApiResourceIdsAsync( operationId.ToGuid() );
        return Success( result );
    }

    /// <summary>
    /// 获取操作关联的Api资源列表
    /// </summary>
    /// <param name="operationId">操作标识</param>
    [HttpGet( "getApis" )]
    public async Task<IActionResult> GetApiResourcesAsync( string operationId ) {
        if ( operationId.IsEmpty() )
            throw new ArgumentNullException( nameof( operationId ) );
        var result = await OperationService.GetApiResourcesAsync( operationId.ToGuid() );
        return Success( result );
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
    public async Task<IActionResult> CreateAsync( CreateOperationRequest request ) {
        if ( request == null )
            return Fail( ApplicationResource.CreateRequestIsEmpty );
        var id = await OperationService.CreateAsync( request );
        var result = await OperationService.GetByIdAsync( id );
        return Success( result );
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="id">标识</param>
    /// <param name="request">修改参数</param>
    [HttpPut( "{id?}" )]
    public async Task<IActionResult> UpdateAsync( string id, OperationDto request ) {
        if ( request == null )
            return Fail( ApplicationResource.UpdateRequestIsEmpty );
        if ( id.IsEmpty() && request.Id.IsEmpty() )
            return Fail( ApplicationResource.IdIsEmpty );
        if ( request.Id.IsEmpty() )
            request.Id = id;
        await OperationService.UpdateAsync( request );
        var result = await OperationService.GetByIdAsync( request.Id );
        return Success( result );
    }

    /// <summary>
    /// 批量删除
    /// </summary>
    /// <param name="ids">标识列表，多个Id用逗号分隔，范例：1,2,3</param>
    [HttpPost( "delete" )]
    public async Task<IActionResult> DeleteAsync( [FromBody] string ids ) {
        await OperationService.DeleteAsync( ids );
        return Success();
    }
}