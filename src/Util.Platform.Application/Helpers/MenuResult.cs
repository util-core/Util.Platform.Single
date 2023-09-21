using Util.Platform.Applications.Dtos.Identity;

namespace Util.Platform.Applications.Helpers; 

/// <summary>
/// 菜单结果
/// </summary>
public class MenuResult : MenuResultBase<ModuleDto> {
    /// <summary>
    /// 初始化菜单结果
    /// </summary>
    /// <param name="data">模块参数列表</param>
    /// <param name="async">是否异步加载</param>
    /// <param name="allExpand">所有节点是否全部展开</param>
    public MenuResult( IEnumerable<ModuleDto> data, bool async = false, bool allExpand = false ) : base( data, async, allExpand ) {
    }
}