using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 角色服务
/// </summary>
public interface IRoleService : IRoleServiceBase<RoleDto, CreateRoleRequest, UpdateRoleRequest, RoleQuery, RoleUsersRequest> {
}