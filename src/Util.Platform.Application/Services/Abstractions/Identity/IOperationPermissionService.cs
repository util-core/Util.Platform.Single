using Util.Platform.Applications.Dtos.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 操作权限服务
/// </summary>
public interface IOperationPermissionService : IOperationPermissionServiceBase<OperationPermissionDto, PermissionRequest> {
}