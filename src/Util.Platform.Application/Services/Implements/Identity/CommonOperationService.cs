using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 常用操作资源服务
/// </summary>
public class CommonOperationService : CommonOperationServiceBase<ISystemUnitOfWork, CommonOperation, CommonOperationDto, CommonOperationQuery>, ICommonOperationService {
    /// <summary>
    /// 初始化常用操作资源服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="repository">仓储</param>
    public CommonOperationService( IServiceProvider serviceProvider, ISystemUnitOfWork unitOfWork, ICommonOperationRepository repository )
        : base( serviceProvider, unitOfWork, repository ) {
    }
}