using Util.Platform.Data;

namespace Util.Platform.Api.Tests; 

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
            .ConfigureWebHostDefaults( webHostBuilder => {
                webHostBuilder.UseTestServer()
                    .Configure( t => {
                        t.UseRouting();
                        t.UseAuthorization();
                        t.UseEndpoints( endpoints => {
                            endpoints.MapControllers();
                        } );
                    } );
            } )
            .AsBuild()
            .AddAop()
            .AddUtc()
            .AddAcl( t => t.AllowAnonymous = true )
            .AddJsonLocalization()
            .AddMemoryCache()
            .AddSqlServerUnitOfWork<IPlatformUnitOfWork, Data.SqlServer.PlatformUnitOfWork>(
                Config.GetConnectionString( "SqlServerTestConnection" ),
                condition: false )
            .AddPgSqlUnitOfWork<IPlatformUnitOfWork, Data.PgSql.PlatformUnitOfWork>(
                Config.GetConnectionString( "PgSqlTestConnection" ),
                condition: false )
            .AddMySqlUnitOfWork<IPlatformUnitOfWork, Data.MySql.PlatformUnitOfWork>(
                Config.GetConnectionString( "MySqlTestConnection" ),
                condition: true )
            .AddUtil();
    }

    /// <summary>
    /// 配置服务
    /// </summary>
    public void ConfigureServices( IServiceCollection services ) {
        services.AddLogging( logBuilder => logBuilder.AddXunitOutput() );
        services.AddControllers();
        services.AddTransient<IHttpClient>( t => {
            var client = new HttpClientService();
            client.SetHttpClient( t.GetService<IHost>().GetTestClient() );
            return client;
        } );
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