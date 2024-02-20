namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 角色仓储
/// </summary>
public class RoleRepository : RoleRepositoryBase<IPlatformUnitOfWork, Role, User>, IRoleRepository {
    /// <summary>
    /// 初始化角色仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public RoleRepository( IPlatformUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}