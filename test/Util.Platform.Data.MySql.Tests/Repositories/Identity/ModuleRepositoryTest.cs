namespace Util.Platform.Data.MySql.Tests.Repositories.Identity;

/// <summary>
/// 模块仓储测试
/// </summary>
public class ModuleRepositoryTest {
    /// <summary>
    /// 工作单元
    /// </summary>
    private readonly IPlatformUnitOfWork _unitOfWork;
    /// <summary>
    /// 应用程序仓储
    /// </summary>
    private readonly IApplicationRepository _applicationRepository;
    /// <summary>
    /// 模块仓储
    /// </summary>
    private readonly IModuleRepository _repository;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public ModuleRepositoryTest( IPlatformUnitOfWork unitOfWork, IApplicationRepository applicationRepository, IModuleRepository repository ) {
        _unitOfWork = unitOfWork;
        _applicationRepository = applicationRepository;
        _repository = repository;
    }

    /// <summary>
    /// 测试添加模块
    /// </summary>
    [Fact]
    public async Task TestAddAsync() {
        //添加应用程序
        var application = ApplicationFakeService.GetApplication();
        application.Init();
        await _applicationRepository.AddAsync( application );

        //定义变量值
        var name = "name";
        var url = "url";
        var icon = "icon";

        //添加模块
        var entity = new Module {
            ApplicationId = application.Id,
            Name = name,
            Uri = url,
            Enabled = true,
            Icon = icon,
            IsExpanded = true

        };
        entity.Init();
        entity.InitPath();
        await _repository.AddAsync( entity );
        await _unitOfWork.CommitAsync();
        _unitOfWork.ClearCache();

        //验证
        var result = await _repository.FindByIdAsync( entity.Id );
        Assert.Equal( application.Id, result.ApplicationId );
        Assert.Equal( name, result.Name );
        Assert.Equal( url, result.Uri );
        Assert.True( result.Enabled );
        Assert.Equal( icon, result.Icon );
        Assert.True( result.IsExpanded );
    }
}