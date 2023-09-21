namespace Util.Platform.Api.Tests.Controllers;

/// <summary>
/// 模块控制器测试
/// </summary>
public class ModuleControllerTest : TestBase {
    /// <summary>
    /// 输出工具
    /// </summary>
    private readonly ITestOutputHelper _testOutputHelper;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public ModuleControllerTest( ITestOutputHelperAccessor testOutputHelperAccessor, IHttpClient client ) : base( client ) {
        _testOutputHelper = testOutputHelperAccessor.Output;
    }

    /// <summary>
    /// 测试创建模块
    /// </summary>
    [Fact]
    public async Task TestCreateAsync() {
        //创建应用程序
        var application = ApplicationDtoFakeService.GetApplicationDto();
        var resultApplication = await PostAsync<ApplicationDto>( "/api/application", application );

        //定义变量值
        var name = "name";
        var url = "url";
        var icon = "icon";

        //创建模块
        var dto = new CreateModuleRequest {
            Name = name,
            Uri = url,
            Icon = icon,
            ApplicationId = resultApplication.Data.Id.ToGuid()
        };
        var result = await PostAsync<ModuleDto>( "/api/module", dto );

        //验证
        Assert.Equal( StateCode.Ok, result.Code );
        Assert.NotEmpty( result.Data.Id );
        Assert.Equal( name, result.Data.Name );
        Assert.Equal( url, result.Data.Uri );
        Assert.Equal( icon, result.Data.Icon );
        _testOutputHelper.WriteLine( Json.ToJson( result ) );
    }
}