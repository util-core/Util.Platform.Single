using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 操作资源服务
/// </summary>
public class OperationService : OperationServiceBase<ISystemUnitOfWork, Resource, Application, Operation, OperationApi,
    OperationDto, ResourceQuery, CreateOperationRequest, ApiResourceDto>, IOperationService {
    /// <summary>
    /// 初始化操作资源服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="resourceRepository">资源仓储</param>
    /// <param name="operationRepository">操作资源仓储</param>
    /// <param name="operationApiRepository">操作Api仓储</param>
    /// <param name="localizer">本地化查找器</param>
    public OperationService( IServiceProvider serviceProvider, ISystemUnitOfWork unitOfWork, IResourceRepository resourceRepository,
        IOperationRepository operationRepository, IOperationApiRepository operationApiRepository, IStringLocalizer localizer )
        : base( serviceProvider, unitOfWork, resourceRepository, operationRepository, operationApiRepository, localizer ) {
    }
}