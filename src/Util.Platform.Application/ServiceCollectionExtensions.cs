using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Util.Platform.Data.Repositories.Identity;

namespace Util.Platform.Applications; 

/// <summary>
/// 服务配置扩展
/// </summary>
public static class ServiceCollectionExtensions {
    /// <summary>
    /// 配置身份标识服务
    /// </summary>
    /// <param name="services">服务集合</param>
    /// <param name="setupAction">权限配置</param>
    public static IServiceCollection AddIdentity( this IServiceCollection services, Action<PermissionOptions> setupAction = null ) {
        var permissionOptions = new PermissionOptions();
        setupAction?.Invoke( permissionOptions );
        services.AddScoped<IdentityUserManager>();
        services.AddScoped<IdentitySignInManager>();
        services.AddIdentity<User, Role>( options => options.Load( permissionOptions ) )
            .AddUserStore<UserRepository>()
            .AddRoleStore<RoleRepository>()
            .AddDefaultTokenProviders()
            .AddErrorDescriber<IdentityErrorLocalizationDescriber>();
        return services;
    }
}