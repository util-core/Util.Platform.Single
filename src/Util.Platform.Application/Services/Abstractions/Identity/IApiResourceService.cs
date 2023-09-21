using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// Api资源服务
/// </summary>
public interface IApiResourceService : IApiResourceServiceBase<ApiResourceDto, CreateApiResourceRequest, ResourceQuery> {
}