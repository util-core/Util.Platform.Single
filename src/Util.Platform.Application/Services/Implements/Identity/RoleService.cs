using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 角色服务
/// </summary>
public class RoleService : RoleServiceBase<IPlatformUnitOfWork, Role, User, RoleDto, CreateRoleRequest, UpdateRoleRequest, RoleQuery, RoleUsersRequest>, IRoleService {
    /// <summary>
    /// 初始化角色服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="roleRepository">角色仓储</param>
    /// <param name="roleManager">角色服务</param>
    public RoleService( IServiceProvider serviceProvider, IPlatformUnitOfWork unitOfWork, IRoleRepository roleRepository, IRoleManager roleManager )
        : base( serviceProvider, unitOfWork, roleRepository, roleManager ) {
    }
}