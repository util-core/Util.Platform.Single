namespace Util.Platform.Data.SqlServer.EntityTypeConfigurations.Identity;

/// <summary>
/// 应用程序类型配置
/// </summary>
public class ApplicationConfiguration : ApplicationConfigurationBase {
    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Application> builder ) {
        builder.HasKey( t => t.Id ).IsClustered( false );
        builder.HasIndex( t => t.CreationTime ).IsClustered();
    }
}