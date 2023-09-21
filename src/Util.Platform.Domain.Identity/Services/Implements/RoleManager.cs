using Microsoft.AspNetCore.Identity;
using Util.Platform.Domain.Models;
using Util.Platform.Domain.Repositories;
using Util.Platform.Domain.Services.Abstractions;

namespace Util.Platform.Domain.Services.Implements;

/// <summary>
/// 角色服务
/// </summary>
public class RoleManager : RoleManagerBase<Role,User>,IRoleManager {
    /// <summary>
    /// 初始化角色服务
    /// </summary>
    /// <param name="roleManager">Identity角色服务</param>
    /// <param name="roleRepository">角色仓储</param>
    /// <param name="userRepository">用户仓储</param>
    /// <param name="localizer">本地化查找器</param>
    public RoleManager( RoleManager<Role> roleManager, IRoleRepository roleRepository, IUserRepository userRepository, IStringLocalizer localizer ) 
        : base( roleManager, roleRepository, userRepository, localizer ) {
    }
}