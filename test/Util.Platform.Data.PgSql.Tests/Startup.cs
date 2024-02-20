using Util.Helpers;

namespace Util.Platform.Data.PgSql.Tests; 

/// <summary>
/// 启动配置
/// </summary>
public class Startup {
    /// <summary>
    /// 配置主机
    /// </summary>
    public void ConfigureHost( IHostBuilder hostBuilder ) {
        Environment.SetDevelopment();
        hostBuilder.ConfigureDefaults( null )
            .AsBuild()
            .AddAop()
            .AddUtc()
            .AddPgSqlUnitOfWork<IPlatformUnitOfWork, PlatformUnitOfWork>( Config.GetConnectionString( "connection" ) )
            .AddUtil();
    }

    /// <summary>
    /// 配置服务
    /// </summary>
    public void ConfigureServices( IServiceCollection services ) {
        services.AddLogging( logBuilder => logBuilder.AddXunitOutput() );
        InitDatabase( services );
    }

    /// <summary>
    /// 初始化数据库
    /// </summary>
    private void InitDatabase( IServiceCollection services ) {
        var unitOfWork = services.BuildServiceProvider().GetService<IPlatformUnitOfWork>();
        unitOfWork.EnsureDeleted();
        unitOfWork.EnsureCreated();
    }
}