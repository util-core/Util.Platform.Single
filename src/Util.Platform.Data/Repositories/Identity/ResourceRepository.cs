namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 资源仓储
/// </summary>
public class ResourceRepository : ResourceRepositoryBase<ISystemUnitOfWork, Resource, Application>, IResourceRepository {
    /// <summary>
    /// 初始化资源仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public ResourceRepository( ISystemUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}