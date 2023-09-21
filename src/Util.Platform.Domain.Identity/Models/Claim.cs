namespace Util.Platform.Domain.Models; 

/// <summary>
/// 声明
/// </summary>
[Description( "声明" )]
public class Claim : ClaimBase<Claim> {
    /// <summary>
    /// 初始化声明
    /// </summary>
    public Claim() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化声明
    /// </summary>
    /// <param name="id">声明标识</param>
    public Claim( Guid id ) : base( id ) {
    }
}