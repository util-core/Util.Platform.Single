using Microsoft.AspNetCore.Identity;
using Util.Platform.Domain.Models;

namespace Util.Platform.Domain.Identity; 

/// <summary>
/// Identity登录服务
/// </summary>
public class IdentitySignInManager : IdentitySignInManagerBase<User,Role> {
    /// <summary>
    /// 初始化Identity登录服务
    /// </summary>
    /// <param name="userManager">Identity用户服务</param>
    /// <param name="contextAccessor">HttpContext访问器</param>
    /// <param name="claimsFactory">用户声明工厂</param>
    /// <param name="optionsAccessor">Identity配置</param>
    /// <param name="logger">日志</param>
    /// <param name="schemes">认证架构提供程序</param>
    /// <param name="confirmation">用户确认信息</param>
    public IdentitySignInManager( UserManager<User> userManager, IHttpContextAccessor contextAccessor,
        IUserClaimsPrincipalFactory<User> claimsFactory, IOptions<IdentityOptions> optionsAccessor,
        ILogger<SignInManager<User>> logger, IAuthenticationSchemeProvider schemes, IUserConfirmation<User> confirmation )
        : base( userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation ) {
    }
}