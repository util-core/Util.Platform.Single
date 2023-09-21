namespace Util.Platform.Domain.Models;

/// <summary>
/// Api资源
/// </summary>
[DisplayName( "Api资源" )]
public class ApiResource : ApiResourceBase<ApiResource> {
    /// <summary>
    /// 初始化Api资源
    /// </summary>
    public ApiResource() : this( Guid.Empty, "", 0 ) {
    }

    /// <summary>
    /// 初始化Api资源
    /// </summary>
    /// <param name="id">模块标识</param>
    /// <param name="path">路径</param>
    /// <param name="level">层级</param>
    public ApiResource( Guid id, string path, int level ) : base( id, path, level ) {
    }
}