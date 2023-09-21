namespace Util.Platform.Domain.Models;

/// <summary>
/// 权限
/// </summary>
[Description( "权限" )]
public class Permission : PermissionBase<Permission,Resource> {
    /// <summary>
    /// 初始化权限
    /// </summary>
    public Permission() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化权限
    /// </summary>
    /// <param name="id">权限标识</param>
    public Permission( Guid id ) : base( id ) {
    }
}