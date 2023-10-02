namespace Util.Platform.Api.Services; 

/// <summary>
/// 资源存储器
/// </summary>
public class ResourceStore : ResourceStoreBase<IIdentityResourceService,IApiResourceService,IdentityResourceDto,ResourceQuery,ApiResourceDto,CreateApiResourceRequest> {
    /// <summary>
    /// 初始化资源存储器
    /// </summary>
    /// <param name="identityResourceService">身份资源服务</param>
    /// <param name="apiResourceService">Api资源服务</param>
    public ResourceStore( IIdentityResourceService identityResourceService, IApiResourceService apiResourceService )
        : base( identityResourceService, apiResourceService ) {
    }
}