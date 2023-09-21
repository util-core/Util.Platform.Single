namespace Util.Platform.Application.Tests.Services;

/// <summary>
/// 声明服务测试
/// </summary>
public class ClaimServiceTest {
    /// <summary>
    /// 声明服务
    /// </summary>
    private readonly IClaimService _service;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public ClaimServiceTest( IClaimService service ) {
        _service = service;
    }

    /// <summary>
    /// 测试创建
    /// </summary>
    [Fact]
    public async Task TestCreateAsync() {
        //创建
        var dto = ClaimDtoFakeService.GetClaimDto();
        var id = await _service.CreateAsync( dto );

        //验证
        var result = await _service.GetByIdAsync( id );
        Assert.NotNull( result );
        Assert.Equal( id, result.Id );
    }
}