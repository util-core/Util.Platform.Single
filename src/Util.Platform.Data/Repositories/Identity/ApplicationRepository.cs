namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 应用程序仓储
/// </summary>
public class ApplicationRepository : ApplicationRepositoryBase<IPlatformUnitOfWork, Application>, IApplicationRepository {
    /// <summary>
    /// 初始化应用程序仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public ApplicationRepository( IPlatformUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}