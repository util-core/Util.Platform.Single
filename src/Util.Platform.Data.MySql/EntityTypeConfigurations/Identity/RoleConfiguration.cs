namespace Util.Platform.Data.MySql.EntityTypeConfigurations.Identity;

/// <summary>
/// 角色类型配置
/// </summary>
public class RoleConfiguration : RoleConfigurationBase {
    /// <summary>
    /// 配置表
    /// </summary>
    protected override void ConfigTable( EntityTypeBuilder<Role> builder ) {
        builder.ToTable( "Role", t => t.HasComment( "角色" ) );
    }

    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Role> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}