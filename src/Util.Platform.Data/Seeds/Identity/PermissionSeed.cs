namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 权限数据种子
/// </summary>
public static class PermissionSeed {
    /// <summary>
    /// 创建默认权限
    /// </summary>
    public static IEnumerable<Permission> CreateDefaultPermissions() {
        return new List<Permission> {
            new ("8BA0D59A-CCC1-469C-8B15-A5867D4832B1".ToGuid()) {
                RoleId = SeedConst.TestRoleId,
                ResourceId = SeedConst.ViewApplicationOperationId,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "d5d0b1e0-28fd-494d-83b5-7d2c871bda0a"u8.ToArray()
            }
        };
    }
}