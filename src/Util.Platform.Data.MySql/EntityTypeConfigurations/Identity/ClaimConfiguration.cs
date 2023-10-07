namespace Util.Platform.Data.MySql.EntityTypeConfigurations.Identity;

/// <summary>
/// 声明类型配置
/// </summary>
public class ClaimConfiguration : ClaimConfigurationBase {
    /// <summary>
    /// 配置表
    /// </summary>
    protected override void ConfigTable( EntityTypeBuilder<Claim> builder ) {
        builder.ToTable( "Claim", t => t.HasComment( "声明" ) );
    }

    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<Claim> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}