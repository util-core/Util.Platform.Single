namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 角色数据种子
/// </summary>
public static class RoleSeed {
    /// <summary>
    /// 创建默认角色
    /// </summary>
    public static IEnumerable<Role> CreateDefaultRoles() {
        return [CreateAdmin(), CreateTest()];
    }

    /// <summary>
    /// 创建管理员角色
    /// </summary>
    private static Role CreateAdmin() {
        var result = new Role( SeedConst.RoleId, $"{SeedConst.RoleId},", 1 ) {
            Code = "admin",
            Name = "管理员",
            NormalizedName = "管理员",
            Remark = "管理员",
            Type = "Role",
            Enabled = true,
            SortId = 1,
            PinYin = "gly",
            CreationTime = DateTime.UtcNow,
            LastModificationTime = DateTime.UtcNow,
            CreatorId = SeedConst.UserId,
            LastModifierId = SeedConst.UserId,
            Version = "90e1f3fb-effd-429c-8646-5d2bafcce5e1"u8.ToArray()
        };
        result.SetAdmin();
        return result;
    }

    /// <summary>
    /// 创建测试角色
    /// </summary>
    private static Role CreateTest() {
        var result = new Role( SeedConst.TestRoleId, $"{SeedConst.TestRoleId},", 1 ) {
            Code = "test",
            Name = "测试人员",
            NormalizedName = "测试人员",
            Remark = "测试人员",
            Type = "Role",
            Enabled = true,
            SortId = 1,
            PinYin = "csry",
            CreationTime = DateTime.UtcNow,
            LastModificationTime = DateTime.UtcNow,
            CreatorId = SeedConst.UserId,
            LastModifierId = SeedConst.UserId,
            Version = "8f594a25-06a1-4a80-8077-8da65eb3de20"u8.ToArray()
        };
        return result;
    }
}