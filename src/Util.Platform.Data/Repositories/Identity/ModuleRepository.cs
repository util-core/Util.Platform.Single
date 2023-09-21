namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 模块仓储
/// </summary>
public class ModuleRepository : ModuleRepositoryBase<Module, Resource, Application>, IModuleRepository {
    /// <summary>
    /// 初始化模块仓储
    /// </summary>
    /// <param name="resourceRepository">资源仓储</param>
    public ModuleRepository( IResourceRepository resourceRepository ) : base( resourceRepository ) {
    }
}