using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 用户服务
/// </summary>
public interface IUserService : IUserServiceBase<UserDto, CreateUserRequest, UserQuery> {
}