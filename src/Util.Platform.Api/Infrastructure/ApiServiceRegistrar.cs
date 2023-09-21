using Util.Helpers;

namespace Util.Platform.Api.Infrastructure;

/// <summary>
/// Api服务注册器
/// </summary>
public class ApiServiceRegistrar : IServiceRegistrar {
    /// <summary>
    /// 排序号
    /// </summary>
    public int OrderId => 30001;

    /// <summary>
    /// 是否启用
    /// </summary>
    public bool Enabled => true;

    /// <summary>
    /// 注册服务 - 加载字体文件
    /// </summary>
    /// <param name="serviceContext">服务上下文</param>
    public Action Register( ServiceContext serviceContext ) {
        var path = Common.GetPhysicalPath( "~/fonts" );
        ImageManager.LoadFonts( path );
        return null;
    }
}