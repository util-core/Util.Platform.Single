using Util.Platform.Data.Seeds.Identity;

namespace Util.Platform.Application.Tests.Helpers; 

/// <summary>
/// 测试辅助操作
/// </summary>
public static class TestHelper {
    /// <summary>
    /// 默认应用程序标识
    /// </summary>
    public static Guid ApplicationId = SeedConst.ApplicationId;
    /// <summary>
    /// 默认角色标识
    /// </summary>
    public static Guid RoleId = SeedConst.RoleId;
    /// <summary>
    /// 默认用户标识
    /// </summary>
    public static Guid UserId = SeedConst.UserId;
    /// <summary>
    /// 应用程序资源标识
    /// </summary>
    public static Guid AppliationResourceId = SeedConst.AppliationResourceId;
    /// <summary>
    /// 声明资源标识
    /// </summary>
    public static Guid ClaimResourceId = SeedConst.ClaimResourceId;
    /// <summary>
    /// 资源标识
    /// </summary>
    public static Guid ResourceId = SeedConst.ResourceId;
    /// <summary>
    /// 角色资源标识
    /// </summary>
    public static Guid RoleResourceId = SeedConst.RoleResourceId;
    /// <summary>
    /// 用户资源标识
    /// </summary>
    public static Guid UserResourceId = SeedConst.UserResourceId;
}