namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 应用程序控制器
/// </summary>
public class ApplicationController : CrudControllerBase<ApplicationDto, ApplicationQuery> {
    /// <summary>
    /// 初始化应用程序控制器
    /// </summary>
    /// <param name="service">应用程序服务</param>
    public ApplicationController( IApplicationService service ) : base( service ) {
        ApplicationService = service;
    }

    /// <summary>
    /// 应用程序服务
    /// </summary>
    protected IApplicationService ApplicationService { get; }

    /// <summary>
    /// 获取全部已启用的应用程序
    /// </summary>
    [HttpGet( "all" )]
    public async Task<IActionResult> GetAllAsync() {
        var result = await ApplicationService.GetEnabledApplicationsAsync();
        return Success( result );
    }

    /// <summary>
    /// 获取已启用的Api应用程序
    /// </summary>
    [HttpGet( "apis" )]
    public async Task<IActionResult> GetApiApplicationsAsync() {
        var result = await ApplicationService.GetEnabledApiApplicationsAsync();
        return Success( result );
    }

    /// <summary>
    /// 获取已启用的非Api应用程序
    /// </summary>
    [HttpGet( "non-apis" )]
    public async Task<IActionResult> GetNonApiApplicationsAsync() {
        var result = await ApplicationService.GetEnabledNonApiApplicationsAsync();
        return Success( result );
    }

    /// <summary>
    /// 获取权限范围
    /// </summary>
    [HttpGet( "scopes" )]
    public async Task<IActionResult> GetScopesAsync() {
        var result = await ApplicationService.GetScopesAsync();
        return Success( result );
    }

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
    public new async Task<IActionResult> PageQueryAsync( [FromQuery] ApplicationQuery query ) {
        return await base.PageQueryAsync( query );
    }

    /// <summary>
    /// 创建
    /// </summary>
    /// <param name="request">创建参数</param>
    [HttpPost]
    public new async Task<IActionResult> CreateAsync( ApplicationDto request ) {
        return await base.CreateAsync( request );
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="id">标识</param>
    /// <param name="request">修改参数</param>
    [HttpPut( "{id?}" )]
    public new async Task<IActionResult> UpdateAsync( string id, ApplicationDto request ) {
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
}