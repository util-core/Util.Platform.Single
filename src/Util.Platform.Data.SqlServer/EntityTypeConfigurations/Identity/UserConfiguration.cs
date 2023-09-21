namespace Util.Platform.Data.SqlServer.EntityTypeConfigurations.Identity;

/// <summary>
/// 用户类型配置
/// </summary>
public class UserConfiguration : UserConfigurationBase {
    /// <summary>
    /// 配置索引
    /// </summary>
    protected override void ConfigIndex( EntityTypeBuilder<User> builder ) {
        builder.HasKey( t => t.Id ).IsClustered( false );
        builder.HasIndex( t => t.CreationTime ).IsClustered();
    }
}