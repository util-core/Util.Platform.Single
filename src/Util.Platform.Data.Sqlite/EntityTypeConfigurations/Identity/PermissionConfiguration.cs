namespace Util.Platform.Data.Sqlite.EntityTypeConfigurations.Identity;

/// <summary>
/// 权限类型配置
/// </summary>
public class PermissionConfiguration : PermissionConfigurationBase {
    /// <summary>
    /// 配置表
    /// </summary>
    protected override void ConfigTable( EntityTypeBuilder<Permission> builder ) {
        builder.ToTable( "Permission", t => t.HasComment( "权限" ) );
    }

    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Permission> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}