using Util.Platform.Applications.Services.Abstractions;

namespace Util.Platform.Applications.Events.EventHandling;

/// <summary>
/// 登录事件处理器
/// </summary>
public class SignInEventHandler : EventHandlerBase<SignInEvent> {
    /// <summary>
    /// 初始化登录事件处理器
    /// </summary>
    /// <param name="cache">缓存</param>
    /// <param name="systemService">系统服务</param>
    public SignInEventHandler( ICache cache, ISystemService systemService ) {
        CacheService = cache ?? throw new ArgumentNullException( nameof( cache ) );
        SystemService = systemService ?? throw new ArgumentNullException( nameof( systemService ) );
    }

    /// <summary>
    /// 缓存
    /// </summary>
    protected ICache CacheService { get; }
    /// <summary>
    /// 系统服务
    /// </summary>
    protected ISystemService SystemService { get; }

    /// <summary>
    /// 处理事件
    /// </summary>
    /// <param name="event">登录事件</param>
    /// <param name="cancellationToken">取消令牌</param>
    public override async Task HandleAsync( SignInEvent @event, CancellationToken cancellationToken ) {
        var userId = @event.UserId;
        if ( @event.State != SignInState.Succeeded )
            return;
        await RemoveUserCache( userId, cancellationToken );
    }

    /// <summary>
    /// 移除用户缓存
    /// </summary>
    private async Task RemoveUserCache( string userId, CancellationToken cancellationToken ) {
        var userPrefix = string.Format( CacheKeyConst.UserPrefix, userId );
        await CacheService.RemoveByPrefixAsync( userPrefix, cancellationToken );
    }
}