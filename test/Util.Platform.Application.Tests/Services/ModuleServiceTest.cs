using Util.Platform.Application.Tests.Helpers;

namespace Util.Platform.Application.Tests.Services;

/// <summary>
/// 模块服务测试
/// </summary>
public class ModuleServiceTest {
    /// <summary>
    /// 应用服务
    /// </summary>
    private readonly IApplicationService _applicationService;
    /// <summary>
    /// 模块服务
    /// </summary>
    private readonly IModuleService _service;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public ModuleServiceTest( IApplicationService applicationService, IModuleService service ) {
        _applicationService = applicationService;
        _service = service;
    }

    /// <summary>
    /// 测试创建和修改模块
    /// </summary>
    [Fact]
    public async Task TestCreateAsync_UpdateAsync() {
        //创建应用程序
        var application = ApplicationDtoFakeService.GetApplicationDto();
        var applicationId = await _applicationService.CreateAsync( application );

        //定义根模块变量值
        var name = "TestCreateAsync_UpdateAsync";
        var url = "url";
        var icon = "icon";

        //创建根模块
        var rootModuleRequest = new CreateModuleRequest {
            Name = name,
            Uri = url,
            Icon = icon,
            ApplicationId = applicationId.ToGuid()
        };
        var rootId = await _service.CreateAsync( rootModuleRequest );

        //验证根模块
        var rootModule = await _service.GetByIdAsync( rootId );
        Assert.NotNull( rootModule );
        Assert.Equal( rootId, rootModule.Id );
        Assert.Equal( name, rootModule.Name );
        Assert.Equal( url, rootModule.Uri );
        Assert.Equal( icon, rootModule.Icon );
        Assert.Equal( 1, rootModule.Level );
        Assert.Equal( $"{rootId},", rootModule.Path );

        //定义子模块变量值
        var childName = "TestCreateAsync_UpdateAsync_Child";
        var childUrl = "childUrl";
        var childIcon = "childIcon";

        //创建子模块1
        var childModuleRequest = new CreateModuleRequest {
            Name = childName,
            Uri = childUrl,
            Icon = childIcon,
            ParentId = rootModule.Id.ToGuid(),
            ApplicationId = applicationId.ToGuid()
        };
        var childId = await _service.CreateAsync( childModuleRequest );

        //验证子模块
        var childModule = await _service.GetByIdAsync( childId );
        Assert.NotNull( childModule );
        Assert.Equal( childId, childModule.Id );
        Assert.Equal( childName, childModule.Name );
        Assert.Equal( childUrl, childModule.Uri );
        Assert.Equal( childIcon, childModule.Icon );
        Assert.Equal( 2, childModule.Level );
        Assert.Equal( $"{rootId},{childId},", childModule.Path );

        //创建子模块2
        var childModuleRequest2 = new CreateModuleRequest {
            Name = $"{childName}2",
            ParentId = rootModule.Id.ToGuid(),
            ApplicationId = applicationId.ToGuid()
        };
        var childId2 = await _service.CreateAsync( childModuleRequest2 );

        //定义子模块变量值
        var childName3 = "TestCreateAsync_UpdateAsync_Child3";
        var childUrl3 = "childUrl3";
        var childIcon3 = "childIcon3";

        //修改子模块1
        childModule.Name = childName3;
        childModule.Uri = childUrl3;
        childModule.Icon = childIcon3;
        childModule.ParentId = childId2;
        await _service.UpdateAsync( childModule );

        //验证子模块
        childModule = await _service.GetByIdAsync( childId );
        Assert.Equal( childName3, childModule.Name );
        Assert.Equal( childUrl3, childModule.Uri );
        Assert.Equal( childIcon3, childModule.Icon );
        Assert.Equal( 3, childModule.Level );
        Assert.Equal( $"{rootId},{childId2},{childId},", childModule.Path );
    }

    /// <summary>
    /// 测试创建模块 - 验证名称重复
    /// </summary>
    [Fact]
    public async Task TestCreateAsync_ValidateDuplicateModuleName() {
        //创建应用程序
        var application = ApplicationDtoFakeService.GetApplicationDto();
        var applicationId = await _applicationService.CreateAsync( application );

        //创建根模块
        var rootModuleRequest = new CreateModuleRequest {
            Name = "TestCreateAsync_ValidateDuplicateModuleName",
            ApplicationId = applicationId.ToGuid()
        };
        var rootId = await _service.CreateAsync( rootModuleRequest );

        //模块名称
        string moduleName = "A";

        //创建子模块A
        var childModuleRequest = new CreateModuleRequest {
            Name = moduleName,
            ParentId = rootId.ToGuid(),
            ApplicationId = applicationId.ToGuid()
        };
        await _service.CreateAsync( childModuleRequest );

        //重复创建子模块A
        childModuleRequest = new CreateModuleRequest {
            Name = moduleName,
            ParentId = rootId.ToGuid(),
            ApplicationId = applicationId.ToGuid()
        };
        await AssertHelper.ThrowsAsync<Warning>( async () => {
            await _service.CreateAsync( childModuleRequest );
        }, "DuplicateModuleName" );
    }

    /// <summary>
    /// 测试修改模块 - 验证名称重复
    /// </summary>
    [Fact]
    public async Task TestUpdateAsync_ValidateDuplicateModuleName() {
        //创建应用程序
        var application = ApplicationDtoFakeService.GetApplicationDto();
        var applicationId = await _applicationService.CreateAsync( application );

        //创建根模块
        var rootModuleRequest = new CreateModuleRequest {
            Name = "TestUpdateAsync_ValidateDuplicateModuleName",
            ApplicationId = applicationId.ToGuid()
        };
        var rootId = await _service.CreateAsync( rootModuleRequest );

        //模块名称
        string moduleNameA = "A";

        //创建子模块A
        var childModuleRequest = new CreateModuleRequest {
            Name = moduleNameA,
            ParentId = rootId.ToGuid(),
            ApplicationId = applicationId.ToGuid()
        };
        await _service.CreateAsync( childModuleRequest );

        //创建子模块B
        childModuleRequest = new CreateModuleRequest {
            Name = "B",
            ParentId = rootId.ToGuid(),
            ApplicationId = applicationId.ToGuid()
        };
        var moduleIdB = await _service.CreateAsync( childModuleRequest );

        //将子模块B的名称修改为A
        var moduleB = await _service.GetByIdAsync( moduleIdB );
        moduleB.Name = moduleNameA;
        await AssertHelper.ThrowsAsync<Warning>( async () => {
            await _service.UpdateAsync( moduleB );
        }, "DuplicateModuleName" );
    }
}