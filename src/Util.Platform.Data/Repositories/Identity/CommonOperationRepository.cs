namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 常用操作资源仓储
/// </summary>
public class CommonOperationRepository : CommonOperationRepositoryBase<ISystemUnitOfWork, CommonOperation>, ICommonOperationRepository {
    /// <summary>
    /// 初始化常用操作资源仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public CommonOperationRepository( ISystemUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}