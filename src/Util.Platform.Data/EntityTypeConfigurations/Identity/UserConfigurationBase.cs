using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Data.EntityTypeConfigurations.Identity;

/// <summary>
/// 用户类型配置
/// </summary>
public abstract class UserConfigurationBase : UserConfigurationBase<User, Role, UserRole> {
    /// <summary>
    /// 配置默认数据
    /// </summary>
    protected override void ConfigData( EntityTypeBuilder<User> builder ) {
        builder.HasData( UserSeed.CreateDefaultUsers() );
    }
}