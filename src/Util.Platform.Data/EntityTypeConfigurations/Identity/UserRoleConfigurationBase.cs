using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Data.EntityTypeConfigurations.Identity;

/// <summary>
/// 用户角色类型配置
/// </summary>
public abstract class UserRoleConfigurationBase : UserRoleConfigurationBase<UserRole> {
    /// <summary>
    /// 配置默认数据
    /// </summary>
    protected override void ConfigData( EntityTypeBuilder<UserRole> builder ) {
        builder.HasData( UserSeed.CreateDefaultUserRoles() );
    }
}