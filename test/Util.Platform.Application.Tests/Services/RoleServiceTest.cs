namespace Util.Platform.Application.Tests.Services;

/// <summary>
/// 角色服务测试
/// </summary>
public class RoleServiceTest {

    #region 测试初始化

    /// <summary>
    /// 系统工作单元
    /// </summary>
    private readonly IPlatformUnitOfWork _unitOfWork;
    /// <summary>
    /// 角色服务
    /// </summary>
    private readonly IRoleService _service;
    /// <summary>
    /// 用户服务
    /// </summary>
    private readonly IUserService _userService;
    /// <summary>
    /// 角色仓储
    /// </summary>
    private readonly IRoleRepository _roleRepository;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public RoleServiceTest( IPlatformUnitOfWork unitOfWork, IRoleService roleService, IUserService userService, IRoleRepository roleRepository ) {
        _unitOfWork = unitOfWork;
        _service = roleService;
        _userService = userService;
        _roleRepository = roleRepository;
    }

    #endregion

    #region 辅助操作

    /// <summary>
    /// 添加角色
    /// </summary>
    /// <param name="name">角色名</param>
    private async Task<string> AddRole( string name ) {
        //创建
        var dto = new CreateRoleRequest {
            Code = name,
            Name = name,
            Remark = name,
            Enabled = true
        };
        return await _service.CreateAsync( dto );
    }

    /// <summary>
    /// 添加用户
    /// </summary>
    /// <param name="name">用户名</param>
    private async Task<string> AddUser( string name ) {
        var dto = new CreateUserRequest {
            UserName = name,
            Password = name
        };
        return await _userService.CreateAsync( dto );
    }

    #endregion

    #region CreateAsync

    /// <summary>
    /// 测试创建
    /// </summary>
    [Fact]
    public async Task TestCreateAsync() {
        //变量
        var value = "TestCreateAsync";

        //添加角色
        var id = await AddRole( value );

        //验证
        var result = await _service.GetByIdAsync( id );
        Assert.NotNull( result );
        Assert.Equal( value, result.Code );
        Assert.Equal( value, result.Name );
        Assert.Equal( value, result.Remark );
        Assert.True( result.Enabled );
    }

    #endregion

    #region UpdateAsync

    /// <summary>
    /// 测试修改
    /// </summary>
    [Fact]
    public async Task TestUpdateAsync() {
        //变量
        var value = "TestUpdateAsync";

        //创建
        var dto = new CreateRoleRequest {
            Code = "Code",
            Name = "Name",
            Remark = "Remark"
        };
        var id = await _service.CreateAsync( dto );

        //修改
        var entity = await _service.GetByIdAsync( id );
        var updateRequest = new UpdateRoleRequest {
            Id = id,
            Code = value,
            Name = value,
            Remark = value,
            Enabled = true,
            Version = entity.Version
        };
        await _service.UpdateAsync( updateRequest );

        //验证
        var result = await _service.GetByIdAsync( id );
        Assert.NotNull( result );
        Assert.Equal( value, result.Code );
        Assert.Equal( value, result.Name );
        Assert.Equal( value, result.Remark );
        Assert.True( result.Enabled );
    }

    #endregion

    #region AddUsersToRoleAsync

    /// <summary>
    /// 测试添加用户到角色
    /// </summary>
    [Fact]
    public async Task TestAddUsersToRoleAsync() {
        //变量
        var role_1 = "TestAddUsersToRoleAsync_Role_1";
        var user_1 = "TestAddUsersToRoleAsync_User_1";
        var user_2 = "TestAddUsersToRoleAsync_User_2";

        //添加角色
        var roleId = ( await AddRole( role_1 ) ).ToGuid();

        //添加用户1
        var userId = ( await AddUser( user_1 ) ).ToGuid();

        //添加用户1到角色
        var dto = new RoleUsersRequest { RoleId = roleId, UserIds = $"{userId}" };
        await _service.AddUsersToRoleAsync( dto );

        //验证
        _unitOfWork.ClearCache();
        var role = await _roleRepository.Find( t => t.Id == roleId ).Include( t => t.Users ).SingleAsync();
        Assert.Single( role.Users );
        Assert.Equal( userId, role.Users.First().Id );

        //添加用户2
        var userId2 = ( await AddUser( user_2 ) ).ToGuid();

        //添加用户1和用户2到角色,说明: 验证重复添加用户
        _unitOfWork.ClearCache();
        dto = new RoleUsersRequest { RoleId = roleId, UserIds = $"{userId},{userId2}" };
        await _service.AddUsersToRoleAsync( dto );

        //验证
        _unitOfWork.ClearCache();
        role = await _roleRepository.Find( t => t.Id == roleId ).Include( t => t.Users ).SingleAsync();
        Assert.Equal( 2, role.Users.Count );
        Assert.Contains( userId, role.Users.Select( t => t.Id ) );
        Assert.Contains( userId2, role.Users.Select( t => t.Id ) );
    }

    #endregion

    #region RemoveUsersFromRoleAsync

    /// <summary>
    /// 测试从角色移除用户
    /// </summary>
    [Fact]
    public async Task TestRemoveUsersFromRoleAsync() {
        //变量
        var role_1 = "TestRemoveUsersFromRoleAsync_Role_1";
        var user_1 = "TestRemoveUsersFromRoleAsync_User_1";
        var user_2 = "TestRemoveUsersFromRoleAsync_User_2";
        var user_3 = "TestRemoveUsersFromRoleAsync_User_3";

        //添加角色
        var roleId = ( await AddRole( role_1 ) ).ToGuid();

        //添加用户1
        var userId = ( await AddUser( user_1 ) ).ToGuid();

        //添加用户2
        var userId2 = ( await AddUser( user_2 ) ).ToGuid();

        //添加用户3
        var userId3 = ( await AddUser( user_3 ) ).ToGuid();

        //添加用户到角色
        _unitOfWork.ClearCache();
        var dto = new RoleUsersRequest { RoleId = roleId, UserIds = $"{userId},{userId2},{userId3}" };
        await _service.AddUsersToRoleAsync( dto );

        //从角色移除用户1和用户2
        _unitOfWork.ClearCache();
        dto = new RoleUsersRequest { RoleId = roleId, UserIds = $"{userId},{userId2}" };
        await _service.RemoveUsersFromRoleAsync( dto );

        //验证
        _unitOfWork.ClearCache();
        var role = await _roleRepository.Find( t => t.Id == roleId ).Include( t => t.Users ).SingleAsync();
        Assert.Single( role.Users );
        Assert.Contains( userId3, role.Users.Select( t => t.Id ) );
    }

    #endregion
}