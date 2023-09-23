using Util.Platform.Domain.Identity;
using Util.Platform.Domain.Models;
using Util.Platform.Domain.Repositories;
using Util.Platform.Domain.Services.Abstractions;

namespace Util.Platform.Domain.Services.Implements;

/// <summary>
/// 用户服务
/// </summary>
public class UserManager : UserManagerBase<User, Role>, IUserManager {
    /// <summary>
    /// 初始化用户服务
    /// </summary>
    /// <param name="userManager">Identity用户服务</param>
    /// <param name="userRepository">用户仓储</param>
    /// <param name="ipAccessor">Ip访问器</param>
    public UserManager( IdentityUserManager userManager, IUserRepository userRepository, IIpAccessor ipAccessor )
        : base( userManager, userRepository, ipAccessor ) {
    }
}