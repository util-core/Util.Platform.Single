namespace Util.Platform.Domain.Models; 

/// <summary>
/// 模块
/// </summary>
[Description( "模块" )]
public class Module : ModuleBase<Module> {
    /// <summary>
    /// 初始化模块
    /// </summary>
    public Module() : this( Guid.Empty, "", 0 ) {
    }

    /// <summary>
    /// 初始化模块
    /// </summary>
    /// <param name="id">模块标识</param>
    /// <param name="path">路径</param>
    /// <param name="level">层级</param>
    public Module( Guid id, string path, int level ) : base( id, path, level ) {
    }
}