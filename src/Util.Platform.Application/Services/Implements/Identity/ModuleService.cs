using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 模块服务
/// </summary>
public class ModuleService : ModuleServiceBase<ISystemUnitOfWork, Resource, Application, Module, ModuleDto, CreateModuleRequest, ResourceQuery>, IModuleService {
    /// <summary>
    /// 初始化模块服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="resourceRepository">资源仓储</param>
    /// <param name="moduleRepository">模块仓储</param>
    /// <param name="localizer">本地化查找器</param>
    public ModuleService( IServiceProvider serviceProvider, ISystemUnitOfWork unitOfWork, IResourceRepository resourceRepository,
        IModuleRepository moduleRepository, IStringLocalizer localizer )
        : base( serviceProvider, unitOfWork, resourceRepository, moduleRepository, localizer ) {
    }
}