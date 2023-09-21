namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 操作仓储
/// </summary>
public class OperationRepository : OperationRepositoryBase<Operation, Resource, Application>, IOperationRepository {
    /// <summary>
    /// 初始化操作仓储
    /// </summary>
    /// <param name="resourceRepository">资源仓储</param>
    public OperationRepository( IResourceRepository resourceRepository ) : base( resourceRepository ) {
    }
}