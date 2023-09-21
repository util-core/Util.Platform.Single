namespace Util.Platform.Domain.Models; 

/// <summary>
/// 资源
/// </summary>
[Description( "资源" )]
public class Resource : ResourceBase<Resource,Application> {
    /// <summary>
    /// 初始化资源
    /// </summary>
    public Resource() : this( Guid.Empty, "", 0 ) {
    }

    /// <summary>
    /// 初始化资源
    /// </summary>
    /// <param name="id">资源标识</param>
    /// <param name="path">路径</param>
    /// <param name="level">层级</param>
    public Resource( Guid id, string path, int level ) : base( id, path, level ) {
    }
}