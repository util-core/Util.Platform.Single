namespace Util.Platform.Data.PgSql.EntityTypeConfigurations.Identity;

/// <summary>
/// 角色类型配置
/// </summary>
public class RoleConfiguration : RoleConfigurationBase {
    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Role> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}