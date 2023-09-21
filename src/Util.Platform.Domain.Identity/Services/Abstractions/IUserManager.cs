using Util.Platform.Domain.Models;

namespace Util.Platform.Domain.Services.Abstractions; 

/// <summary>
/// 用户服务
/// </summary>
public interface IUserManager : IUserManagerBase<User,Role> {
}