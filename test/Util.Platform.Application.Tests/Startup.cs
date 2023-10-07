using Util.Helpers;

namespace Util.Platform.Application.Tests; 

/// <summary>
/// 启动配置
/// </summary>
public class Startup {
    /// <summary>
    /// 配置主机
    /// </summary>
    public void ConfigureHost( IHostBuilder hostBuilder ) {
        Util.Helpers.Environment.SetDevelopment();
        hostBuilder.ConfigureDefaults( null )
            .AsBuild()
            .AddAop()
            .AddUtc()
            .AddJsonLocalization()
            .AddMemoryCache()
            .AddSqlServerUnitOfWork<ISystemUnitOfWork, Data.SqlServer.SystemUnitOfWork>(
                Config.GetConnectionString( "SqlServer" ),
                condition: true )
            .AddPgSqlUnitOfWork<ISystemUnitOfWork, Data.PgSql.SystemUnitOfWork>(
                Config.GetConnectionString( "PgSql" ),
                condition: false )
            .AddMySqlUnitOfWork<ISystemUnitOfWork, Data.MySql.SystemUnitOfWork>(
                Config.GetConnectionString( "MySql" ),
                condition: false )
            .AddUtil();
    }

    /// <summary>
    /// 配置服务
    /// </summary>
    public void ConfigureServices( IServiceCollection services ) {
        services.AddLogging( logBuilder => logBuilder.AddXunitOutput() );
        services.AddIdentity();
        InitDatabase( services );
    }

    /// <summary>
    /// 初始化数据库
    /// </summary>
    private void InitDatabase( IServiceCollection services ) {
        var unitOfWork = services.BuildServiceProvider().GetService<ISystemUnitOfWork>();
        unitOfWork.EnsureDeleted();
        unitOfWork.EnsureCreated();
    }
}