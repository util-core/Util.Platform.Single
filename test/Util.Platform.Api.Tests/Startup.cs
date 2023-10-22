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
            .AddSqlServerUnitOfWork<ISystemUnitOfWork, Data.SqlServer.SystemUnitOfWork>(
                Config.GetConnectionString( "SqlServerTestConnection" ),
                condition: false )
            .AddPgSqlUnitOfWork<ISystemUnitOfWork, Data.PgSql.SystemUnitOfWork>(
                Config.GetConnectionString( "PgSqlTestConnection" ),
                condition: false )
            .AddMySqlUnitOfWork<ISystemUnitOfWork, Data.MySql.SystemUnitOfWork>(
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
        var unitOfWork = services.BuildServiceProvider().GetService<ISystemUnitOfWork>();
        unitOfWork.EnsureDeleted();
        unitOfWork.EnsureCreated();
    }
}