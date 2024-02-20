namespace Util.Platform.Data.MySql;

/// <summary>
/// 工作单元
/// </summary>
public class PlatformUnitOfWork : MySqlUnitOfWorkBase, IPlatformUnitOfWork {
    /// <summary>
    /// 初始化工作单元
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="options">配置项</param>
    public PlatformUnitOfWork( IServiceProvider serviceProvider,DbContextOptions<PlatformUnitOfWork> options ) : base( serviceProvider,options ) {
    }
}