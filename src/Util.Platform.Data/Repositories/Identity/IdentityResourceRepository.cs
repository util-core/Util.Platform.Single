namespace Util.Platform.Data.Repositories.Identity;

/// <summary>
/// 身份资源仓储
/// </summary>
public class IdentityResourceRepository : IdentityResourceRepositoryBase<IdentityResource, Resource, Application>, IIdentityResourceRepository {
    /// <summary>
    /// 初始化身份资源仓储
    /// </summary>
    /// <param name="resourceRepository">资源仓储</param>
    public IdentityResourceRepository( IResourceRepository resourceRepository ) : base( resourceRepository ) {
    }
}