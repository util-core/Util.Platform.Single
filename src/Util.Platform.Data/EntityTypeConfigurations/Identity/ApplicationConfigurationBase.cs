using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Data.EntityTypeConfigurations.Identity;

/// <summary>
/// 应用程序类型配置
/// </summary>
public abstract class ApplicationConfigurationBase : ApplicationConfigurationBase<Application> {
    /// <summary>
    /// 配置默认数据
    /// </summary>
    protected override void ConfigData( EntityTypeBuilder<Application> builder ) {
        builder.HasData( ApplicationSeed.CreateDefaultApplications() );
    }
}