using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 模块服务
/// </summary>
public class ModuleService : ModuleServiceBase<IPlatformUnitOfWork, Resource, Application, Module, ModuleDto, CreateModuleRequest, ResourceQuery>, IModuleService {
    /// <summary>
    /// 初始化模块服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="resourceRepository">资源仓储</param>
    /// <param name="moduleRepository">模块仓储</param>
    public ModuleService( IServiceProvider serviceProvider, IPlatformUnitOfWork unitOfWork, IResourceRepository resourceRepository,
        IModuleRepository moduleRepository )
        : base( serviceProvider, unitOfWork, resourceRepository, moduleRepository ) {
    }
}