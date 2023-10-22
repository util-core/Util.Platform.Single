using Util.Platform.Applications.Services.Abstractions;

namespace Util.Platform.Applications.Services.Implements;

/// <summary>
/// 访问控制列表服务
/// </summary>
public class AclService : IAclService {
    /// <summary>
    /// 初始化访问控制列表服务
    /// </summary>
    /// <param name="systemService">系统服务</param>
    /// <exception cref="ArgumentNullException"></exception>
    public AclService( ISystemService systemService ) {
        SystemService = systemService ?? throw new ArgumentNullException( nameof( systemService ) );
    }

    /// <summary>
    /// 系统服务
    /// </summary>
    protected ISystemService SystemService { get; }

    /// <inheritdoc />
    public async Task SetAclAsync( string userId, string applicationId ) {
        await SystemService.SetAclCacheAsync( applicationId.ToGuid(), userId.ToGuid() );
    }
}