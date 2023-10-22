namespace Util.Platform.Applications.Events.EventHandling;

/// <summary>
/// 退出登录事件处理器
/// </summary>
public class SignOutEventHandler : EventHandlerBase<SignOutEvent> {
    /// <summary>
    /// 初始化退出登录事件处理器
    /// </summary>
    /// <param name="cache">缓存</param>
    public SignOutEventHandler( ICache cache ) {
        CacheService = cache ?? throw new ArgumentNullException( nameof( cache ) );
    }

    /// <summary>
    /// 缓存
    /// </summary>
    protected ICache CacheService { get; }

    /// <summary>
    /// 处理事件
    /// </summary>
    /// <param name="event">退出登录事件</param>
    /// <param name="cancellationToken">取消令牌</param>
    public override async Task HandleAsync( SignOutEvent @event, CancellationToken cancellationToken ) {
        var userPrefix = string.Format( CacheKeyConst.UserPrefix, @event.UserId );
        await CacheService.RemoveByPrefixAsync( userPrefix, cancellationToken );
    }
}