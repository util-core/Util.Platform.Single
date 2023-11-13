using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 声明服务
/// </summary>
public class ClaimService : ClaimServiceBase<ISystemUnitOfWork, Claim, ClaimDto, ClaimQuery>, IClaimService {
    /// <summary>
    /// 初始化声明服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="repository">声明仓储</param>
    public ClaimService( IServiceProvider serviceProvider, ISystemUnitOfWork unitOfWork, IClaimRepository repository ) : base( serviceProvider, unitOfWork, repository ) {
    }
}