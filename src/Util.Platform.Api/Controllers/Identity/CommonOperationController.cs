namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 常用操作资源控制器
/// </summary>
[Acl( "commonOperation.view" )]
public class CommonOperationController : CrudControllerBase<CommonOperationDto, CommonOperationQuery> {
    /// <summary>
    /// 初始化常用操作资源控制器
    /// </summary>
    /// <param name="service">常用操作资源服务</param>
    public CommonOperationController( ICommonOperationService service ) : base( service ) {
        CommonOperationService = service;
    }

    /// <summary>
    /// 常用操作资源服务
    /// </summary>
    protected ICommonOperationService CommonOperationService { get; }

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
    public new async Task<IActionResult> PageQueryAsync( [FromQuery] CommonOperationQuery query ) {
        return await base.PageQueryAsync( query );
    }

    /// <summary>
    /// 获取项列表
    /// </summary>
    [HttpGet( "Items" )]
    public async Task<IActionResult> GetItemsAsync() {
        var names = await CommonOperationService.GetEnabledNamesAsync();
        var result = names.Select( dto => new Item( dto.Name, dto.Name ) );
        return Success( result );
    }

    /// <summary>
    /// 批量删除
    /// </summary>
    /// <param name="ids">标识列表，多个Id用逗号分隔，范例：1,2,3</param>
    [HttpPost( "delete" )]
    [Acl( "commonOperation.delete" )]
    public new async Task<IActionResult> DeleteAsync( [FromBody] string ids ) {
        return await base.DeleteAsync( ids );
    }

    /// <summary>
    /// 批量保存
    /// </summary>
    /// <param name="request">保存参数</param>
    [HttpPost( "save" )]
    [Acl( "commonOperation.save" )]
    public new async Task<IActionResult> SaveAsync( SaveModel request ) {
        return await base.SaveAsync( request );
    }
}