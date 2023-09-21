namespace Util.Platform.Api.Controllers;

/// <summary>
/// 模块控制器
/// </summary>
public class ModuleController : NgZorroTreeControllerBase<ModuleDto, CreateModuleRequest, ModuleDto, ResourceQuery> {
    /// <summary>
    /// 初始化模块控制器
    /// </summary>
    /// <param name="service">模块服务</param>
    public ModuleController( IModuleService service ) : base( service ) {
        ModuleService = service;
    }

    /// <summary>
    /// 模块服务
    /// </summary>
    public IModuleService ModuleService { get; }

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
    /// 创建模块
    /// </summary>
    /// <param name="request">创建参数</param>
    [HttpPost]
    public new async Task<IActionResult> CreateAsync( CreateModuleRequest request ) {
        if ( request == null )
            return Fail( ApplicationResource.CreateRequestIsEmpty );
        var id = await ModuleService.CreateAsync( request );
        var result = await ModuleService.GetByIdAsync( id );
        return Success( result );
    }

    /// <summary>
    /// 修改模块
    /// </summary>
    /// <param name="id">标识</param>
    /// <param name="request">修改参数</param>
    [HttpPut( "{id?}" )]
    public new async Task<IActionResult> UpdateAsync( string id, ModuleDto request ) {
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