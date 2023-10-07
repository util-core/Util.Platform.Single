namespace Util.Platform.Data.MySql.EntityTypeConfigurations.Identity;

/// <summary>
/// 资源类型配置
/// </summary>
public class ResourceConfiguration : ResourceConfigurationBase {
    /// <summary>
    /// 配置表
    /// </summary>
    protected override void ConfigTable( EntityTypeBuilder<Resource> builder ) {
        builder.ToTable( "Resource", t => t.HasComment( "资源" ) );
    }

    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Resource> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}