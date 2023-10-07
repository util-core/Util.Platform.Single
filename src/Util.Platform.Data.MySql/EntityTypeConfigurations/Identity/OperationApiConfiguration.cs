namespace Util.Platform.Data.MySql.EntityTypeConfigurations.Identity;

/// <summary>
/// 操作Api类型配置
/// </summary>
public class OperationApiConfiguration : OperationApiConfigurationBase {
    /// <summary>
    /// 配置表
    /// </summary>
    protected override void ConfigTable( EntityTypeBuilder<OperationApi> builder ) {
        builder.ToTable( "OperationApi", t => t.HasComment( "操作Api" ) );
    }

    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<OperationApi> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}