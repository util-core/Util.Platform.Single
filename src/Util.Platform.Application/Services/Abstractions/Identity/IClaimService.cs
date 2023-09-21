using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 声明服务
/// </summary>
public interface IClaimService : IClaimServiceBase<ClaimDto, ClaimQuery> {
}