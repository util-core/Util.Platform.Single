namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 用户仓储
/// </summary>
public class UserRepository : UserRepositoryBase<IPlatformUnitOfWork, User, Role>, IUserRepository {
    /// <summary>
    /// 初始化用户仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public UserRepository( IPlatformUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}