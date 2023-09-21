using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 模块服务
/// </summary>
public interface IModuleService : IModuleServiceBase<ModuleDto, CreateModuleRequest, ResourceQuery> {
}