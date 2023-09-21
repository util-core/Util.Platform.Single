namespace Util.Platform.Domain.Models; 

/// <summary>
/// 角色
/// </summary>
[Description( "角色" )]
public class Role : RoleBase<Role,User> {
    /// <summary>
    /// 初始化角色
    /// </summary>
    public Role() : this( Guid.Empty, "", 0 ) {
    }

    /// <summary>
    /// 初始化角色
    /// </summary>
    /// <param name="id">角色标识</param>
    /// <param name="path">路径</param>
    /// <param name="level">层级</param>
    public Role( Guid id, string path, int level ) : base( id, path, level ) {
    }
}