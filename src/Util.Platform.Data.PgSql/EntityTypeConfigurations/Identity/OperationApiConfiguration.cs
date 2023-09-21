namespace Util.Platform.Data.PgSql.EntityTypeConfigurations.Identity;

/// <summary>
/// 操作Api类型配置
/// </summary>
public class OperationApiConfiguration : OperationApiConfigurationBase {
    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<OperationApi> builder ) {
        builder.HasIndex( t => t.Id ).IsUnique();
    }
}