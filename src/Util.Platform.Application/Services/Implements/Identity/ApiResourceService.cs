using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// Api资源服务
/// </summary>
public class ApiResourceService : ApiResourceServiceBase<ISystemUnitOfWork, Resource, Application, ApiResource, ApiResourceDto, CreateApiResourceRequest, ResourceQuery>, IApiResourceService {
    /// <summary>
    /// 初始化Api资源服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="resourceRepository">资源仓储</param>
    /// <param name="apiResourceRepository">Api资源仓储</param>
    public ApiResourceService( IServiceProvider serviceProvider, ISystemUnitOfWork unitOfWork, IResourceRepository resourceRepository,
        IApiResourceRepository apiResourceRepository )
        : base( serviceProvider, unitOfWork, resourceRepository, apiResourceRepository ) {
    }
}