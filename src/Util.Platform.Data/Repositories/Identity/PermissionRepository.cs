namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 权限仓储
/// </summary>
public class PermissionRepository : PermissionRepositoryBase<IPlatformUnitOfWork, Permission, Application, Resource>, IPermissionRepository {
    /// <summary>
    /// 初始化权限仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public PermissionRepository( IPlatformUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}