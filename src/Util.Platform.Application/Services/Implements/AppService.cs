using Util.Platform.Applications.Helpers;
using Util.Platform.Applications.Services.Abstractions;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements;

/// <summary>
/// 前端应用服务
/// </summary>
public class AppService : ServiceBase, IAppService {

    #region 构造方法

    /// <summary>
    /// 初始化前端应用服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="cache">缓存服务</param>
    /// <param name="applicationRepository">应用程序仓储</param>
    /// <param name="userRepository">用户仓储</param>
    /// <param name="permissionService">权限服务</param>
    public AppService( IServiceProvider serviceProvider, ICache cache, IApplicationRepository applicationRepository,
        IUserRepository userRepository, IPermissionService permissionService ) : base( serviceProvider ) {
        CacheService = cache ?? throw new ArgumentNullException( nameof( cache ) );
        ApplicationRepository = applicationRepository ?? throw new ArgumentNullException( nameof( applicationRepository ) );
        UserRepository = userRepository ?? throw new ArgumentNullException( nameof( userRepository ) );
        PermissionService = permissionService ?? throw new ArgumentNullException( nameof( permissionService ) );
    }

    #endregion

    #region 属性

    /// <summary>
    /// 缓存服务
    /// </summary>
    protected ICache CacheService { get; }
    /// <summary>
    /// 应用程序仓储
    /// </summary>
    protected IApplicationRepository ApplicationRepository { get; }
    /// <summary>
    /// 用户仓储
    /// </summary>
    protected IUserRepository UserRepository { get; }
    /// <summary>
    /// 权限服务
    /// </summary>
    protected IPermissionService PermissionService { get; }

    #endregion

    #region GetAppDataAsync

    /// <inheritdoc />
    public async Task<AppData> GetAppDataAsync( Guid applicationId, Guid userId, CancellationToken cancellationToken = default ) {
        var result = new AppData();
        if ( applicationId.IsEmpty() || userId.IsEmpty() )
            return result;
        var application = await ApplicationRepository.FindByIdAsync( applicationId, cancellationToken );
        if ( application == null )
            return result;
        var user = await UserRepository.FindByIdAsync( userId, cancellationToken );
        if ( user == null )
            return result;
        var appResources = await PermissionService.GetAppResourcesAsync( applicationId, userId, cancellationToken );
        result.App = new AppInfo { Name = application.Name, Description = application.Remark };
        result.Menu = new MenuResult( appResources.Modules ).GetResult();
        result.Acl = appResources.Acl;
        result.IsAdmin = appResources.IsAdmin;
        result.User = new UserInfo { Name = user.UserName, Avatar = "/assets/tmp/img/avatar.jpg", Email = user.Email };
        return result;
    }

    #endregion

    #region GetAppDataByCacheAsync

    /// <inheritdoc />
    public async Task<AppData> GetAppDataByCacheAsync( Guid applicationId, Guid userId, CancellationToken cancellationToken = default ) {
        var result = new AppData();
        if ( applicationId.IsEmpty() || userId.IsEmpty() )
            return result;
        var cacheKey = new GetAppDataCacheKey( userId.ToString(), applicationId.ToString() );
        return await CacheService.GetAsync( cacheKey, async () => await GetAppDataAsync( applicationId, userId, cancellationToken ), cancellationToken: cancellationToken );
    }

    #endregion
}