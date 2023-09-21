using Util.Platform.Applications.Dtos.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// Api权限服务
/// </summary>
public interface IApiPermissionService : IApiPermissionServiceBase<ApiResourceDto, PermissionRequest> {
}