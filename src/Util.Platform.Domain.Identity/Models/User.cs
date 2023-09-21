namespace Util.Platform.Domain.Models;

/// <summary>
/// 用户
/// </summary>
[Description( "用户" )]
public class User : UserBase<User,Role> {
    /// <summary>
    /// 初始化用户
    /// </summary>
    public User() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化用户
    /// </summary>
    /// <param name="id">用户标识</param>
    public User( Guid id ) : base( id ) {
    }
}