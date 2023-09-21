namespace Util.Platform.Domain.Models; 

/// <summary>
/// 操作Api
/// </summary>
[Description( "操作Api" )]
public class OperationApi : OperationApiBase<OperationApi> {
    /// <summary>
    /// 初始化操作Api
    /// </summary>
    public OperationApi() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化操作Api
    /// </summary>
    /// <param name="id">操作Api标识</param>
    public OperationApi( Guid id ) : base( id ) {
    }
}