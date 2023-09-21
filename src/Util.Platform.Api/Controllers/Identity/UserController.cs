namespace Util.Platform.Api.Controllers.Identity;

/// <summary>
/// 用户控制器
/// </summary>
public class UserController : CrudControllerBase<UserDto, CreateUserRequest, UserDto, UserQuery> {
    /// <summary>
    /// 初始化用户控制器
    /// </summary>
    /// <param name="service">用户服务</param>
    public UserController( IUserService service ) : base( service ) {
        UserService = service;
    }

    /// <summary>
    /// 用户服务
    /// </summary>
    protected IUserService UserService { get; }

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
    public new async Task<IActionResult> QueryAsync( [FromQuery] UserQuery query ) {
        return await base.QueryAsync( query );
    }

    /// <summary>
    /// 分页查询
    /// </summary>
    /// <param name="query">查询参数</param>
    [HttpGet]
    public new async Task<IActionResult> PageQueryAsync( [FromQuery] UserQuery query ) {
        return await base.PageQueryAsync( query );
    }

    /// <summary>
    /// 创建
    /// </summary>
    /// <param name="request">创建参数</param>
    [HttpPost]
    public new async Task<IActionResult> CreateAsync( CreateUserRequest request ) {
        return await base.CreateAsync( request );
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