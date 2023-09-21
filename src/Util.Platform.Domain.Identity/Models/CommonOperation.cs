namespace Util.Platform.Domain.Models; 

/// <summary>
/// 常用操作资源
/// </summary>
[Description( "常用操作资源" )]
public class CommonOperation : CommonOperationBase<CommonOperation> {
    /// <summary>
    /// 初始化常用操作资源
    /// </summary>
    public CommonOperation() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化常用操作资源
    /// </summary>
    /// <param name="id">常用操作资源标识</param>
    public CommonOperation( Guid id ) : base( id ) {
    }
}