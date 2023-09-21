namespace Util.Platform.Applications.Services.Abstractions;

/// <summary>
/// 前端应用服务
/// </summary>
public interface IAppService : IService {
    /// <summary>
    /// 获取应用数据
    /// </summary>
    /// <param name="applicationId">应用程序标识</param>
    /// <param name="userId">用户标识</param>.
    /// <param name="cancellationToken">取消令牌</param>
    Task<AppData> GetAppDataAsync( Guid applicationId, Guid userId, CancellationToken cancellationToken = default );
    /// <summary>
    /// 通过缓存获取应用数据
    /// </summary>
    /// <param name="applicationId">应用程序标识</param>
    /// <param name="userId">用户标识</param>
    /// <param name="cancellationToken">取消令牌</param>
    Task<AppData> GetAppDataByCacheAsync( Guid applicationId, Guid userId, CancellationToken cancellationToken = default );
}