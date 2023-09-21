namespace Util.Platform.Domain.Models;

/// <summary>
/// 操作
/// </summary>
[Description( "操作" )]
public class Operation : OperationBase<Operation> {
    /// <summary>
    /// 初始化操作
    /// </summary>
    public Operation() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化操作
    /// </summary>
    /// <param name="id">操作标识</param>
    public Operation( Guid id ) : base( id ) {
    }
}