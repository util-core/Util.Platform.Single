using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Data.EntityTypeConfigurations.Identity;

/// <summary>
/// 角色类型配置
/// </summary>
public abstract class RoleConfigurationBase : RoleConfigurationBase<Role, User> {
    /// <summary>
    /// 配置默认数据
    /// </summary>
    protected override void ConfigData( EntityTypeBuilder<Role> builder ) {
        builder.HasData( RoleSeed.CreateDefaultRoles() );
    }
}