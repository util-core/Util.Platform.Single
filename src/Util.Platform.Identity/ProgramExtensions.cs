using Util.Helpers;
using Util.Platform.Domain.Models;

namespace Util.Platform.Identity;

/// <summary>
/// 应用配置扩展
/// </summary>
public static class ProgramExtensions {
    /// <summary>
    /// 配置控制器
    /// </summary>
    public static WebApplicationBuilder AddControllers( this WebApplicationBuilder builder ) {
        builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
        return builder;
    }

    /// <summary>
    /// Util基础功能配置
    /// </summary>
    /// <param name="builder">Web应用生成器</param>
    public static WebApplicationBuilder AddUtil( this WebApplicationBuilder builder ) {
        builder.AsBuild()
            .AddAop()
            .AddUtc()
            .AddTenant( t => {
                t.IsEnabled = false;
                t.Resolvers.Add( new IdentityTenantResolver { Priority = 99 } );
            } )
            .AddJsonLocalization( options => {
                options.Cultures = new[] { "zh-CN", "en-US" };
            } )
            .AddSerilog()
            .AddRedisCache( options => {
                options.DBConfig.Configuration = builder.Configuration.GetConnectionString( "Redis" );
            } )
            .AddUtil();
        return builder;
    }

    /// <summary>
    /// 配置Identity工作单元
    /// </summary>
    public static WebApplicationBuilder AddIdentityUnitOfWork( this WebApplicationBuilder builder ) {
        var dbType = builder.GetDatabaseType();
        builder.AsBuild()
            .AddSqlServerUnitOfWork<ISystemUnitOfWork, Util.Platform.Data.SqlServer.SystemUnitOfWork>(
                builder.GetIdentitySqlServerConnectionString(),
                condition: dbType == DatabaseType.SqlServer )
            .AddPgSqlUnitOfWork<ISystemUnitOfWork, Util.Platform.Data.PgSql.SystemUnitOfWork>(
                builder.GetIdentityPgSqlConnectionString(),
                condition: dbType == DatabaseType.PgSql );
        return builder;
    }

    /// <summary>
    /// 获取数据库类型
    /// </summary>
    public static DatabaseType GetDatabaseType( this WebApplicationBuilder builder ) {
        try {
            var dbType = builder.Configuration["DatabaseType"];
            return dbType.IsEmpty() ? DatabaseType.SqlServer : Util.Helpers.Enum.Parse<DatabaseType>( dbType );
        }
        catch {
            return DatabaseType.SqlServer;
        }
    }

    /// <summary>
    /// 获取Identity SqlServer数据库连接字符串
    /// </summary>
    public static string GetIdentitySqlServerConnectionString( this WebApplicationBuilder builder ) {
        return builder.Configuration.GetConnectionString( "SqlServer" );
    }

    /// <summary>
    /// 获取Identity PgSql数据库连接字符串
    /// </summary>
    public static string GetIdentityPgSqlConnectionString( this WebApplicationBuilder builder ) {
        return builder.Configuration.GetConnectionString( "PgSql" );
    }

    /// <summary>
    /// 配置身份标识服务
    /// </summary>
    /// <param name="builder">Web应用生成器</param>
    /// <param name="setupAction">权限配置</param>
    public static WebApplicationBuilder AddIdentity( this WebApplicationBuilder builder, Action<PermissionOptions> setupAction = null ) {
        builder.Services.AddIdentity( setupAction );
        return builder;
    }

    /// <summary>
    /// 配置身份验证服务器
    /// </summary>
    public static WebApplicationBuilder AddIdentityServer( this WebApplicationBuilder builder ) {
        builder.Services.AddIdentityServer( options => {
            options.Events.RaiseErrorEvents = true;
            options.Events.RaiseInformationEvents = true;
            options.Events.RaiseFailureEvents = true;
            options.Events.RaiseSuccessEvents = true;
        } )
            .AddAspNetIdentity<User>()
            .AddDeveloperSigningCredential()
            .AddResourceStore<ResourceStore>()
            .AddClientStore<ClientStore>()
            .AddCorsPolicyService<CorsPolicyService>()
            .AddResourceOwnerValidator<ResourceOwnerPasswordValidator>()
            .AddProfileService<ProfileService>();
        return builder;
    }

    /// <summary>
    /// 配置Cors
    /// </summary>
    public static void AddCors( this WebApplicationBuilder builder ) {
        builder.Services.AddCors( options => options.AddPolicy( "cors", policy => {
            policy.SetIsOriginAllowed( _ => true );
            policy.AllowAnyHeader().AllowAnyMethod().AllowCredentials();
        } ) );
    }

    /// <summary>
    /// 配置转发头部
    /// </summary>
    public static void AddForwardedHeaders( this WebApplicationBuilder builder ) {
        builder.Services.Configure<ForwardedHeadersOptions>( options => {
            options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            options.KnownNetworks.Clear();
            options.KnownProxies.Clear();
        } );
    }

    /// <summary>
    /// 配置Http日志
    /// </summary>
    public static WebApplicationBuilder AddHttpLogging( this WebApplicationBuilder builder ) {
        builder.Services.AddHttpLogging( options => options.LoggingFields = HttpLoggingFields.All );
        return builder;
    }

    /// <summary>
    /// 配置异常页
    /// </summary>
    public static void UseCustomExceptionPage( this WebApplication app ) {
        if ( app.Environment.IsDevelopment() ) {
            app.UseDeveloperExceptionPage();
        }
        else {
            app.UseExceptionHandler( "/Error" );
            app.UseHsts();
        }
    }

    /// <summary>
    /// 配置基路径
    /// </summary>
    public static void UsePathBase( this WebApplication app ) {
        var pathBase = app.GetPathBase();
        if ( pathBase.IsEmpty() )
            return;
        app.UsePathBase( pathBase );
    }

    /// <summary>
    /// 获取基路径
    /// </summary>
    public static string GetPathBase( this WebApplication app ) {
        return app.Configuration["PathBase"];
    }

    /// <summary>
    /// 配置Cookie策略
    /// </summary>
    public static void UseCookiePolicy( this WebApplication app ) {
        app.UseCookiePolicy( new CookiePolicyOptions {
            MinimumSameSitePolicy = SameSiteMode.Lax
        } );
    }

    /// <summary>
    /// 配置身份服务器
    /// </summary>
    public static void UseCustomIdentityServer( this WebApplication app ) {
        try {
            app.UseIdentityServer();
        }
        catch ( Exception ) {
            if ( Common.IsLinux )
                throw;
        }
    }
}