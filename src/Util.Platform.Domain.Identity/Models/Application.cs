namespace Util.Platform.Domain.Models;

/// <summary>
/// 应用程序
/// </summary>
[Description( "应用程序" )]
public class Application : ApplicationBase<Application> {
    /// <summary>
    /// 初始化应用程序
    /// </summary>
    public Application() : this( Guid.Empty ) {
    }

    /// <summary>
    /// 初始化应用程序
    /// </summary>
    /// <param name="id">应用程序标识</param>
    public Application( Guid id ) : base( id ) {
    }
}