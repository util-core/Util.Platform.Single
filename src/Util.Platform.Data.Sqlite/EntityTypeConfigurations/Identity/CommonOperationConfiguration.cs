namespace Util.Platform.Data.Sqlite.EntityTypeConfigurations.Identity;

/// <summary>
/// 常用操作资源类型配置
/// </summary>
public class CommonOperationConfiguration : CommonOperationConfigurationBase {
    /// <summary>
    /// 配置表
    /// </summary>
    protected override void ConfigTable( EntityTypeBuilder<CommonOperation> builder ) {
        builder.ToTable( "CommonOperation", t => t.HasComment( "常用操作资源" ) );
    }

    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<CommonOperation> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}