using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 常用操作资源服务
/// </summary>
public interface ICommonOperationService : ICommonOperationServiceBase<CommonOperationDto, CommonOperationQuery> {
}