﻿using Util.Platform.Applications.Dtos.Identity;
using Util.Platform.Applications.Services.Abstractions.Identity;

namespace Util.Platform.Applications.Services.Implements.Identity;

/// <summary>
/// 身份资源服务
/// </summary>
public class IdentityResourceService : IdentityResourceServiceBase<IPlatformUnitOfWork, Resource, Application, IdentityResource, IdentityResourceDto, ResourceQuery>, IIdentityResourceService {
    /// <summary>
    /// 初始化身份资源服务
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="unitOfWork">工作单元</param>
    /// <param name="resourceRepository">资源仓储</param>
    /// <param name="identityResourceRepository">身份资源仓储</param>
    public IdentityResourceService( IServiceProvider serviceProvider, IPlatformUnitOfWork unitOfWork, IResourceRepository resourceRepository,
        IIdentityResourceRepository identityResourceRepository )
        : base( serviceProvider, unitOfWork, resourceRepository, identityResourceRepository ) {
    }
}