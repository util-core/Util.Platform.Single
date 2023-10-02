using Util.Platform.Domain.Models;

namespace Util.Platform.Api.Services; 

/// <summary>
/// 用户配置服务
/// </summary>
public class ProfileService : ProfileServiceBase<User,Role,IdentityUserManager,IApplicationService,ApplicationDto,ApplicationQuery> {
    /// <summary>
    /// 初始化用户身份配置服务
    /// </summary>
    /// <param name="userManager">用户服务</param>
    /// <param name="claimsFactory">用户声明工厂</param>
    /// <param name="applicationService">应用程序服务</param>
    public ProfileService( IdentityUserManager userManager, IUserClaimsPrincipalFactory<User> claimsFactory,  
        IApplicationService applicationService ) : base( userManager, claimsFactory, applicationService ) {
    }
}