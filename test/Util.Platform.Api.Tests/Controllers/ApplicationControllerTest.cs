namespace Util.Platform.Api.Tests.Controllers;

/// <summary>
/// 应用程序控制器测试
/// </summary>
public class ApplicationControllerTest : TestBase {
    /// <summary>
    /// 输出工具
    /// </summary>
    private readonly ITestOutputHelper _testOutputHelper;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public ApplicationControllerTest( ITestOutputHelperAccessor testOutputHelperAccessor, IHttpClient client ) : base( client ) {
        _testOutputHelper = testOutputHelperAccessor.Output;
    }

    /// <summary>
    /// 测试创建
    /// </summary>
    [Fact]
    public async Task TestCreateAsync() {
        //服务地址
        var url = "/api/application";

        //创建实体
        var dto = ApplicationDtoFakeService.GetApplicationDto();
        var result = await PostAsync<ApplicationDto>( url, dto );

        //验证
        Assert.Equal( StateCode.Ok, result.Code );
        Assert.NotEmpty( result.Data.Id );
        _testOutputHelper.WriteLine( Json.ToJson( result ) );
    }
}