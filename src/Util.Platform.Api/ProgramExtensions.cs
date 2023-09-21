using Util.Helpers;

namespace Util.Platform.Api;

/// <summary>
/// 应用配置扩展
/// </summary>
public static class ProgramExtensions {
    /// <summary>
    /// Util基础功能配置
    /// </summary>
    /// <param name="builder">Web应用生成器</param>
    public static WebApplicationBuilder AddUtil( this WebApplicationBuilder builder ) {
        builder.AsBuild()
            .AddAop()
            .AddUtc()
            .AddTenant( t => t.IsEnabled = false )
            .AddAcl<PermissionManager>()
            .AddJsonLocalization( options => {
                options.Cultures = new[] { "zh-CN", "en-US" };
            } )
            .AddMemoryCache()
            .AddSerilog()
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
    /// 配置认证方案
    /// </summary>
    public static WebApplicationBuilder AddIdentityAuthentication( this WebApplicationBuilder builder ) {
        builder.Services
            .AddAuthentication( options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            } )
            .AddJwtBearer( JwtBearerDefaults.AuthenticationScheme, options => {
                options.Authority = builder.GetIdentityUrl();
                options.Audience = builder.GetAudience();
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters.ValidateAudience = false;
                options.TokenValidationParameters.ValidateIssuer = false;
            } );
        return builder;
    }

    /// <summary>
    /// 获取身份认证服务器地址
    /// </summary>
    public static string GetIdentityUrl( this WebApplicationBuilder builder ) {
        return builder.Configuration["IdentityUrl"];
    }

    /// <summary>
    /// 获取令牌接收方
    /// </summary>
    public static string GetAudience( this WebApplicationBuilder builder ) {
        return builder.Configuration["Audience"];
    }

    /// <summary>
    /// 配置Http日志
    /// </summary>
    public static WebApplicationBuilder AddHttpLogging( this WebApplicationBuilder builder ) {
        builder.Services.AddHttpLogging( options => options.LoggingFields = HttpLoggingFields.All );
        return builder;
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
    /// 配置Swagger服务
    /// </summary>
    public static WebApplicationBuilder AddSwagger( this WebApplicationBuilder builder ) {
        if ( builder.Environment.IsDevelopment() == false )
            return builder;
        var openApi = builder.Configuration.GetSection( "OpenApi" );
        if ( openApi.Exists() == false )
            return builder;
        var version = openApi.GetValue<string>( "Version" );
        var document = openApi.GetRequiredSection( "Document" );
        var title = document.GetValue<string>( "Title" );
        var description = document.GetValue<string>( "Description" );
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen( options => {
            options.SwaggerDoc( version, new OpenApiInfo {
                Title = title,
                Description = description,
                Version = version
            } );
            var identityUrl = builder.GetIdentityUrl();
            options.AddSecurityDefinition( "oauth2", new OpenApiSecurityScheme {
                Type = SecuritySchemeType.OAuth2,
                Flows = new OpenApiOAuthFlows {
                    AuthorizationCode = new OpenApiOAuthFlow {
                        AuthorizationUrl = new Uri( $"{identityUrl}/connect/authorize" ),
                        TokenUrl = new Uri( $"{identityUrl}/connect/token" )
                    }
                }
            } );
            var oAuthScheme = new OpenApiSecurityScheme {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" }
            };
            options.AddSecurityRequirement( new() {
                [oAuthScheme] = new List<string>()
            } );
        } );
        return builder;
    }

    /// <summary>
    /// 配置异常页
    /// </summary>
    public static void UseExceptionPage( this WebApplication app ) {
        if ( app.Environment.IsDevelopment() == false )
            return;
        app.UseDeveloperExceptionPage();
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
    /// 配置Swagger
    /// </summary>
    public static void UseCustomSwagger( this WebApplication app ) {
        if ( app.Environment.IsDevelopment() == false )
            return;
        var openApi = app.Configuration.GetSection( "OpenApi" );
        if ( openApi.Exists() == false )
            return;
        var version = openApi.GetValue<string>( "Version" );
        var endpoint = openApi.GetRequiredSection( "Endpoint" );
        var name = endpoint.GetValue<string>( "Name" );
        var clientId = endpoint.GetValue<string>( "ClientId" );
        var appName = endpoint.GetValue<string>( "AppName" );
        app.UseSwagger();
        app.UseSwaggerUI( options => {
            options.SwaggerEndpoint( $"/swagger/{version}/swagger.json", name );
            options.OAuthClientId( clientId );
            options.OAuthAppName( appName );
            options.OAuthScopes( "openid" );
            options.OAuthUsePkce();
            options.OAuthConfigObject.ClientSecret = "secret";
        } );
        app.MapGet( "/", () => Results.LocalRedirect( "~/swagger" ) );
    }

    /// <summary>
    /// 数据迁移
    /// </summary>
    public static async Task MigrateAsync( this WebApplication app ) {
        if ( app.Environment.IsDevelopment() == false )
            return;
        var enabled = app.Configuration.GetValue<bool>( "Migration:Enabled" );
        if ( enabled == false )
            return;
        var migrationName = app.Configuration.GetValue<string>( "Migration:Name" );
        using var scope = app.Services.CreateScope();
        var unitOfWork = scope.ServiceProvider.GetRequiredService<ISystemUnitOfWork>();
        var appliedMigrations = await unitOfWork.GetAppliedMigrationsAsync();
        if ( appliedMigrations.Any( t => t.Contains( migrationName ) ) )
            return;
        var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationService>();
        InstallEfTool( migrationService );
        app.Logger.LogInformation( "准备迁移数据..." );
        Migrate( app,migrationService, migrationName, "Util.Platform.Data.SqlServer" );
        Migrate( app, migrationService, migrationName, "Util.Platform.Data.PgSql" );
        var policy = scope.ServiceProvider.GetRequiredService<IPolicy>();
        await policy.Retry().HandleException<Exception>().Forever().Wait()
            .OnRetry( ( exception, retry ) => {
                var message = "迁移数据发生异常：{Message},已重试 {retry} 次.";
                app.Logger.LogWarning( exception, message, exception.Message, retry );
            } )
            .ExecuteAsync( async () => {
                await unitOfWork.MigrateAsync();
            } );
        app.Logger.LogInformation( "迁移数据成功..." );
    }

    /// <summary>
    /// 安装和更新 dotnet-ef 工具
    /// </summary>
    private static void InstallEfTool( IMigrationService migrationService ) {
        migrationService.InstallEfTool().UpdateEfTool();
    }

    /// <summary>
    /// 迁移
    /// </summary>
    private static void Migrate( WebApplication app, IMigrationService migrationService,string migrationName,string dataProjectName ) {
        try {
            var path = Common.JoinPath( Common.GetParentDirectory(), dataProjectName );
            migrationService.AddMigration( migrationName, path ).Migrate( path );
        }
        catch ( Exception exception ) {
            app.Logger.LogError( exception, "迁移数据发生异常..." );
        }
    }
}