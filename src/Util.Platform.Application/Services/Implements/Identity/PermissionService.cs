using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 权限服务
/// </summary>
public class PermissionService : PermissionServiceBase<IPlatformUnitOfWork, Permission, Resource, Application,
    User, Role, Module, AppResources, ModuleDto>, IPermissionService {
    /// <summary>
    /// 初始化权限服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="cache">缓存服务</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="permissionRepository">权限仓储</param>
    /// <param name="userRepository">用户仓储</param>
    /// <param name="roleRepository">角色仓储</param>
    /// <param name="resourceRepository">资源仓储</param>
    /// <param name="moduleRepository">模块仓储</param>
    public PermissionService( IServiceProvider serviceProvider, ICache cache, IPlatformUnitOfWork unitOfWork,
        IPermissionRepository permissionRepository, IUserRepository userRepository, IRoleRepository roleRepository,
        IResourceRepository resourceRepository, IModuleRepository moduleRepository )
        : base( serviceProvider, cache, unitOfWork, permissionRepository, userRepository, roleRepository, resourceRepository, moduleRepository ) {
    }
}