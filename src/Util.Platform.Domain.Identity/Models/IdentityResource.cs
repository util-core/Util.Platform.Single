namespace Util.Platform.Domain.Models;

/// <summary>
/// 身份资源
/// </summary>
[Description( "身份资源" )]
public class IdentityResource : IdentityResourceBase<IdentityResource> {
    /// <summary>
    /// 初始化身份资源
    /// </summary>
    public IdentityResource() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化身份资源
    /// </summary>
    /// <param name="id">身份资源标识</param>
    public IdentityResource( Guid id ) : base( id ) {
    }
}