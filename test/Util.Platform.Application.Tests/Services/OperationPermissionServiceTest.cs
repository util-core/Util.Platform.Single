using Util.Platform.Application.Tests.Helpers;

namespace Util.Platform.Application.Tests.Services;

/// <summary>
/// 操作权限服务测试
/// </summary>
public class OperationPermissionServiceTest {
    /// <summary>
    /// 操作权限服务
    /// </summary>
    private readonly IOperationPermissionService _service;
    /// <summary>
    /// 权限仓储
    /// </summary>
    private readonly IPermissionRepository _repository;

    /// <summary>
    /// 测试初始化
    /// </summary>
    public OperationPermissionServiceTest( IOperationPermissionService service, IPermissionRepository repository ) {
        _service = service;
        _repository = repository;
    }

    /// <summary>
    /// 测试授予操作权限
    /// </summary>
    [Fact]
    public async Task TestGrantOperationPermissionsAsync() {
        //变量定义
        var applicationId = TestHelper.ApplicationId;
        var roleId = TestHelper.RoleId;
        var resourceId = TestHelper.AppliationResourceId;
        var resourceId2 = TestHelper.UserResourceId;
        var resourceId3 = TestHelper.RoleResourceId;


        //清理操作权限
        await _service.ClearOperationPermissionsAsync( applicationId, roleId );

        //授权资源1,2
        var dto = new PermissionRequest {
            ApplicationId = applicationId,
            RoleId = roleId,
            ResourceIds = $"{resourceId},{resourceId2}"
        };
        await _service.GrantOperationPermissionsAsync( dto );

        //验证
        var permissions = await _repository.GetOperationPermissionResourceIdsAsync( applicationId, roleId, false );
        Assert.Contains( permissions, id => id == resourceId );
        Assert.Contains( permissions, id => id == resourceId2 );

        //授权资源2,3
        dto = new PermissionRequest {
            ApplicationId = applicationId,
            RoleId = roleId,
            ResourceIds = $"{resourceId2},{resourceId3}"
        };
        await _service.GrantOperationPermissionsAsync( dto );

        //验证
        permissions = await _repository.GetOperationPermissionResourceIdsAsync( applicationId, roleId, false );
        Assert.DoesNotContain( permissions, id => id == resourceId );
        Assert.Contains( permissions, id => id == resourceId2 );
        Assert.Contains( permissions, id => id == resourceId3 );
    }
}