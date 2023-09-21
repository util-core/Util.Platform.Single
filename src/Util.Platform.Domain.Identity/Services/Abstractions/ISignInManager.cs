using Util.Platform.Domain.Models;

namespace Util.Platform.Domain.Services.Abstractions; 

/// <summary>
/// 登录服务
/// </summary>
public interface ISignInManager : ISignInManagerBase<User,Role> {
}