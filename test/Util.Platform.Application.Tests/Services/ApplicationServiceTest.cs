namespace Util.Platform.Application.Tests.Services;

/// <summary>
/// 应用程序服务测试
/// </summary>
public class ApplicationServiceTest {
    /// <summary>
    /// 应用程序服务
    /// </summary>
    private readonly IApplicationService _service;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public ApplicationServiceTest( IApplicationService service ) {
        _service = service;
    }

    /// <summary>
    /// 测试创建
    /// </summary>
    [Fact]
    public async Task TestCreateAsync() {
        //创建
        var dto = ApplicationDtoFakeService.GetApplicationDto();
        var id = await _service.CreateAsync( dto );

        //验证
        var result = await _service.GetByIdAsync( id );
        Assert.NotNull( result );
        Assert.Equal( id, result.Id );
    }
}