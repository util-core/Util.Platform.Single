namespace Util.Platform.Application.Tests.Services;

/// <summary>
/// 用户服务测试
/// </summary>
public class UserServiceTest {
    /// <summary>
    /// 用户服务
    /// </summary>
    private readonly IUserService _service;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public UserServiceTest( IUserService service ) {
        _service = service;
    }

    /// <summary>
    /// 测试创建用户
    /// </summary>
    [Fact]
    public async Task TestCreateAsync() {
        //定义变量
        var value = "TestCreateAsync@a.com";

        //创建
        var dto = new CreateUserRequest {
            Email = value,
            Password = "b"
        };
        var id = await _service.CreateAsync( dto );

        //验证
        var result = await _service.GetByIdAsync( id );
        Assert.NotNull( result );
        Assert.Equal( id, result.Id );
        Assert.Equal( value, result.UserName );
        Assert.Equal( value, result.Email );
    }
}