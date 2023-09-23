using Util.Platform.Domain.Identity;
using Util.Platform.Domain.Models;
using Util.Platform.Domain.Services.Abstractions;

namespace Util.Platform.Domain.Services.Implements;

/// <summary>
/// 登录服务
/// </summary>
public class SignInManager : SignInManagerBase<User, Role>, ISignInManager {
    /// <summary>
    /// 初始化登录服务
    /// </summary>
    /// <param name="signInManager">Identity登录服务</param>
    /// <param name="userManager">用户服务</param>
    /// <param name="localizer">本地化查找器</param>
    /// <param name="ipAccessor">Ip访问器</param>
    public SignInManager( IdentitySignInManager signInManager, IUserManager userManager, IStringLocalizer localizer, IIpAccessor ipAccessor )
        : base( signInManager, userManager, localizer, ipAccessor ) {
    }
}