using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 应用程序服务
/// </summary>
public interface IApplicationService : IApplicationServiceBase<ApplicationDto, ApplicationQuery> {
}