using Util.Platform.Applications.Dtos.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 操作资源服务
/// </summary>
public interface IOperationService : IOperationServiceBase<OperationDto, ResourceQuery, CreateOperationRequest> {
}