namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 操作Api仓储
/// </summary>
public class OperationApiRepository : OperationApiRepositoryBase<ISystemUnitOfWork, OperationApi, Resource, Application>, IOperationApiRepository {
    /// <summary>
    /// 初始化操作Api仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public OperationApiRepository( ISystemUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}