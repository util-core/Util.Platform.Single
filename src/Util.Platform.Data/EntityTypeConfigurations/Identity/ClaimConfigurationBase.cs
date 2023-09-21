using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Data.EntityTypeConfigurations.Identity;

/// <summary>
/// 声明类型配置
/// </summary>
public abstract class ClaimConfigurationBase : ClaimConfigurationBase<Claim> {
    /// <summary>
    /// 配置默认数据
    /// </summary>
    protected override void ConfigData( EntityTypeBuilder<Claim> builder ) {
        builder.HasData( ClaimSeed.CreateDefaultClaims() );
    }
}