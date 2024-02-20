using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 操作权限服务
/// </summary>
public class OperationPermissionService : OperationPermissionServiceBase<IPlatformUnitOfWork, Permission, Resource, Application,
    User, Role, OperationPermissionDto, PermissionRequest>, IOperationPermissionService {
    /// <summary>
    /// 初始化操作权限服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="permissionRepository">权限仓储</param>
    /// <param name="userRepository">用户仓储</param>
    /// <param name="roleRepository">角色仓储</param>
    /// <param name="resourceRepository">资源仓储</param>
    public OperationPermissionService( IServiceProvider serviceProvider, IPlatformUnitOfWork unitOfWork, IPermissionRepository permissionRepository,
        IUserRepository userRepository, IRoleRepository roleRepository, IResourceRepository resourceRepository )
        : base( serviceProvider, unitOfWork, permissionRepository, userRepository, roleRepository, resourceRepository ) {
    }
}