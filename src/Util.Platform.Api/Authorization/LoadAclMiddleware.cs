using Util.Caching;
using Util.Platform.Applications.Services.Abstractions;
using ISession = Util.Sessions.ISession;

namespace Util.Platform.Api.Authorization;

/// <summary>
/// 访问控制列表加载中间件
/// </summary>
public class LoadAclMiddleware {
    /// <summary>
    /// 中间件管道
    /// </summary>
    private readonly RequestDelegate _next;

    /// <summary>
    /// 初始化访问控制列表加载中间件
    /// </summary>
    /// <param name="next">中间件管道</param>
    public LoadAclMiddleware( RequestDelegate next ) {
        _next = next;
    }

    /// <summary>
    /// 执行管道
    /// </summary>
    /// <param name="httpContext">Http上下文</param>
    public async Task InvokeAsync( HttpContext httpContext ) {
        if ( _next == null )
            return;
        if ( httpContext == null ) {
            await _next( httpContext );
            return;
        }
        await LoadAcl( httpContext );
        await _next( httpContext );
    }

    /// <summary>
    /// 加载访问控制列表
    /// </summary>
    private async Task LoadAcl( HttpContext httpContext ) {
        var cache = httpContext.RequestServices.GetRequiredService<ICache>();
        var session = httpContext.RequestServices.GetRequiredService<ISession>();
        var key = $"{string.Format( CacheKeyConst.UserPrefix, session.UserId )}-load-acl-{session.GetApplicationId()}";
        var exists = await cache.ExistsAsync( key );
        if ( exists )
            return;
        var service = httpContext.RequestServices.GetRequiredService<ISystemService>();
        await service.SetAclCacheAsync( session.GetUserId() );
        await cache.SetAsync( key, 1 );
    }
}