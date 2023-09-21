using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Data.EntityTypeConfigurations.Identity;

/// <summary>
/// 常用操作资源类型配置
/// </summary>
public abstract class CommonOperationConfigurationBase : CommonOperationConfigurationBase<CommonOperation> {
    /// <summary>
    /// 配置默认数据
    /// </summary>
    protected override void ConfigData( EntityTypeBuilder<CommonOperation> builder ) {
        builder.HasData( CommonOperationSeed.CreateDefaultOperations() );
    }
}