using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Data.Queries.Identity;

namespace Util.Platform.Applications.Services.Abstractions.Identity;

/// <summary>
/// 身份资源服务
/// </summary>
public interface IIdentityResourceService : IIdentityResourceServiceBase<IdentityResourceDto, ResourceQuery> {
}