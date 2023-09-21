namespace Util.Platform.Domain.Models;

/// <summary>
/// 用户角色
/// </summary>
[Description( "用户角色" )]
public class UserRole : UserRoleBase {
    /// <summary>
    /// 初始化用户角色
    /// </summary>
    public UserRole() : base( Guid.Empty, Guid.Empty ) {
    }

    /// <summary>
    /// 初始化用户角色
    /// </summary>
    /// <param name="userId">用户标识</param>
    /// <param name="roleId">角色标识</param>
    public UserRole( Guid userId, Guid roleId ) : base( userId, roleId ) {
    }
}