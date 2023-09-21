using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Data.EntityTypeConfigurations.Identity;

/// <summary>
/// 权限类型配置
/// </summary>
public abstract class PermissionConfigurationBase : PermissionConfigurationBase<Permission, Resource> {
    /// <summary>
    /// 配置默认数据
    /// </summary>
    protected override void ConfigData( EntityTypeBuilder<Permission> builder ) {
        builder.HasData( PermissionSeed.CreateDefaultPermissions() );
    }
}