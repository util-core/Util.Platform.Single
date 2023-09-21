using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 用户服务
/// </summary>
public class UserService : UserServiceBase<ISystemUnitOfWork, User, Role, UserDto, CreateUserRequest, UserQuery>, IUserService {
    /// <summary>
    /// 初始化用户服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="userRepository">用户仓储</param>
    /// <param name="userManager">用户服务</param>
    public UserService( IServiceProvider serviceProvider, ISystemUnitOfWork unitOfWork, IUserRepository userRepository, IUserManager userManager )
        : base( serviceProvider, unitOfWork, userRepository, userManager ) {
    }
}