﻿namespace Util.Platform.Applications.Events.EventHandling;

/// <summary>
/// 资源更新事件处理器
/// </summary>
public class ResourceUpdateEventHandler : EventHandlerBase<EntityUpdatedEvent<Resource>> {
    /// <summary>
    /// 初始化资源更新事件处理器
    /// </summary>
    /// <param name="cache">缓存</param>
    /// <param name="session">用户会话</param>
    public ResourceUpdateEventHandler( ICache cache, ISession session ) {
        CacheService = cache ?? throw new ArgumentNullException( nameof( cache ) );
        Session = session ?? throw new ArgumentNullException( nameof( session ) );
    }

    /// <summary>
    /// 缓存
    /// </summary>
    protected ICache CacheService { get; }

    /// <summary>
    /// 用户会话
    /// </summary>
    protected ISession Session { get; }

    /// <summary>
    /// 处理事件
    /// </summary>
    /// <param name="event">资源更新事件</param>
    /// <param name="cancellationToken">取消令牌</param>
    public override async Task HandleAsync( EntityUpdatedEvent<Resource> @event, CancellationToken cancellationToken ) {
        await RemoveGetAppDataCache( @event, cancellationToken );
    }

    /// <summary>
    /// 清除应用数据缓存
    /// </summary>
    private async Task RemoveGetAppDataCache( EntityUpdatedEvent<Resource> @event, CancellationToken cancellationToken ) {
        if ( @event.Entity.Type != ResourceType.Module )
            return;
        var cacheKey = new GetAppDataCacheKey( Session.UserId, Session.GetApplicationId().ToString() );
        await CacheService.RemoveAsync( cacheKey, cancellationToken );
    }
}