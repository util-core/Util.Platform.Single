using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 应用程序服务
/// </summary>
public class ApplicationService : ApplicationServiceBase<IPlatformUnitOfWork, Application, IdentityResource, ApiResource, ApplicationDto, ApplicationQuery>, IApplicationService {
    /// <summary>
    /// 初始化应用程序服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="cache">缓存服务</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="applicationRepository">应用程序仓储</param>
    /// <param name="identityResourceRepository">身份资源仓储</param>
    /// <param name="apiResourceRepository">Api资源仓储</param>
    public ApplicationService( IServiceProvider serviceProvider, ICache cache, IPlatformUnitOfWork unitOfWork,
        IApplicationRepository applicationRepository, IIdentityResourceRepository identityResourceRepository,
        IApiResourceRepository apiResourceRepository )
        : base( serviceProvider, cache, unitOfWork, applicationRepository, identityResourceRepository, apiResourceRepository ) {
    }
}