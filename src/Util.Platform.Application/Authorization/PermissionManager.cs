using Util.Platform.Applications.Services.Abstractions;

namespace Util.Platform.Applications.Authorization;

/// <summary>
/// 权限管理器
/// </summary>
public class PermissionManager : IPermissionManager {
    /// <summary>
    /// 用户会话
    /// </summary>
    private readonly ISession _session;
    /// <summary>
    /// 系统服务
    /// </summary>
    private readonly ISystemService _systemService;

    /// <summary>
    /// 初始化权限管理器
    /// </summary>
    /// <param name="session">用户会话</param>
    /// <param name="systemService">系统服务</param>
    public PermissionManager( ISession session, ISystemService systemService ) {
        _session = session ?? throw new ArgumentNullException( nameof(session) );
        _systemService = systemService ?? throw new ArgumentNullException( nameof( systemService ) );
    }

    /// <summary>
    /// 是否有权限访问
    /// </summary>
    /// <param name="resourceUri">资源标识</param>
    public bool HasPermission( string resourceUri ) {
        var userId = _session.UserId.ToGuid();
        if ( userId.IsEmpty() )
            return false;
        var isAdmin = _systemService.IsAdmin( userId );
        if ( isAdmin )
            return true;
        return true;
    }

    /// <inheritdoc />
    public async Task<bool> HasPermissionAsync( string resourceUri,CancellationToken cancellationToken = default ) {
        var userId = _session.UserId.ToGuid();
        if ( userId.IsEmpty() )
            return false;
        var isAdmin = await _systemService.IsAdminByCacheAsync( userId, cancellationToken );
        if ( isAdmin )
            return true;
        return await _systemService.HasPermissionByCacheAsync( userId, resourceUri, cancellationToken );
    }
}