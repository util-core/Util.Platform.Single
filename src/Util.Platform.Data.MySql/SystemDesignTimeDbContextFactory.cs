using Util.Helpers;

namespace Util.Platform.Data.MySql; 

/// <summary>
/// 设计时数据上下文工厂
/// </summary>
public class SystemDesignTimeDbContextFactory : IDesignTimeDbContextFactory<SystemUnitOfWork> {
    /// <summary>
    /// 创建数据上下文
    /// </summary>
    public SystemUnitOfWork CreateDbContext( string[] args ) {
        var connectionString = GetConnectionString();
        var services = Ioc.GetServices();
        services.AddDbContext<SystemUnitOfWork>( t => t.UseMySql( connectionString,ServerVersion.AutoDetect( connectionString ) ) );
        return Ioc.Create<SystemUnitOfWork>();
    }

    /// <summary>
    /// 获取连接字符串
    /// </summary>
    private string GetConnectionString() {
        var basePath = Common.JoinPath( Common.GetParentDirectory(), "Util.Platform.Api" );
        var config = Config.CreateConfiguration( basePath );
        return config.GetConnectionString( "MySql" );
    }
}