namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 声明仓储
/// </summary>
public class ClaimRepository : ClaimRepositoryBase<ISystemUnitOfWork, Claim>, IClaimRepository {
    /// <summary>
    /// 初始化声明仓储
    /// </summary>
    /// <param name="unitOfWork">工作单元</param>
    public ClaimRepository( ISystemUnitOfWork unitOfWork ) : base( unitOfWork ) {
    }
}