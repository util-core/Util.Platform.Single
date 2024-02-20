using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements;

/// <summary>
/// 系统服务
/// </summary>
public class SystemService : SystemServiceBase<IPlatformUnitOfWork, Permission, Resource, Application, User, Role, AppResources, ModuleDto, LoginRequest>, ISystemService {
    /// <summary>
    /// 初始化系统服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="eventBus">事件总线</param>
    /// <param name="cache">缓存服务</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="permissionService">权限服务</param>
    /// <param name="signInManager">登录服务</param>
    /// <param name="userManager">用户服务</param>
    public SystemService( IServiceProvider serviceProvider, IEventBus eventBus, ICache cache, IPlatformUnitOfWork unitOfWork, IPermissionService permissionService,
        ISignInManager signInManager, IUserManager userManager )
        : base( serviceProvider, eventBus, cache, unitOfWork, permissionService, signInManager, userManager ) {
    }
}