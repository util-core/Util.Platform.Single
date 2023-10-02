namespace Util.Platform.Api.Middlewares; 

/// <summary>
/// Jwt认证中间件
/// </summary>
public class JwtBearerAuthenticationMiddleware {
    /// <summary>
    /// 中间件管道
    /// </summary>
    private readonly RequestDelegate _next;

    /// <summary>
    /// 初始化Jwt认证中间件
    /// </summary>
    /// <param name="next">中间件管道</param>
    /// <param name="schemes">认证方案提供器</param>
    public JwtBearerAuthenticationMiddleware( RequestDelegate next, IAuthenticationSchemeProvider schemes ) {
        _next = next ?? throw new ArgumentNullException( nameof( next ) );
        Schemes = schemes ?? throw new ArgumentNullException( nameof( schemes ) );
    }

    /// <summary>
    /// 认证方案提供器
    /// </summary>
    public IAuthenticationSchemeProvider Schemes { get; set; }

    /// <summary>
    /// 执行管道
    /// </summary>
    /// <param name="context">Http上下文</param>
    public async Task Invoke( HttpContext context ) {
        context.Features.Set<IAuthenticationFeature>( new AuthenticationFeature {
            OriginalPath = context.Request.Path,
            OriginalPathBase = context.Request.PathBase
        } );
        var handlers = context.RequestServices.GetRequiredService<IAuthenticationHandlerProvider>();
        foreach ( var scheme in await Schemes.GetRequestHandlerSchemesAsync() ) {
            var authenticationHandler = await handlers.GetHandlerAsync( context, scheme.Name );
            if ( authenticationHandler is IAuthenticationRequestHandler handler && await handler.HandleRequestAsync() ) {
                return;
            }
        }
        var result = await context.AuthenticateAsync( JwtBearerDefaults.AuthenticationScheme );
        if ( result?.Principal != null ) {
            context.User = result.Principal;
        }
        if ( result?.Succeeded ?? false ) {
            var authFeatures = new AuthenticationFeatures( result );
            context.Features.Set<IHttpAuthenticationFeature>( authFeatures );
            context.Features.Set<IAuthenticateResultFeature>( authFeatures );
        }
        await _next( context );
    }
}