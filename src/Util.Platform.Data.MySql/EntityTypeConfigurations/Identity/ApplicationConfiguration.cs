namespace Util.Platform.Data.MySql.EntityTypeConfigurations.Identity;

/// <summary>
/// 应用程序类型配置
/// </summary>
public class ApplicationConfiguration : ApplicationConfigurationBase {
    /// <summary>
    /// 配置表
    /// </summary>
    protected override void ConfigTable( EntityTypeBuilder<Application> builder ) {
        builder.ToTable( "Application", t => t.HasComment( "应用程序" ) );
    }

    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Application> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}