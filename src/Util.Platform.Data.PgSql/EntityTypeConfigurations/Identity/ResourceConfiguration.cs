namespace Util.Platform.Data.PgSql.EntityTypeConfigurations.Identity;

/// <summary>
/// 资源类型配置
/// </summary>
public class ResourceConfiguration : ResourceConfigurationBase {
    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Resource> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}