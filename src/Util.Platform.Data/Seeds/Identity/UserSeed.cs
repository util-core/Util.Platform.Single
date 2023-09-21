namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 用户数据种子
/// </summary>
public static class UserSeed {
    /// <summary>
    /// 创建默认用户
    /// </summary>
    public static IEnumerable<User> CreateDefaultUsers() {
        return new[] { CreateAdmin(), CreateTest() };
    }

    /// <summary>
    /// 创建管理员
    /// </summary>
    private static User CreateAdmin() {
        return new User( SeedConst.UserId ) {
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            PasswordHash = "AQAAAAEAACcQAAAAEP+Co27jHqc5JQ0LPfqcMbUtsrCHkZhK/oRC/xPysrV9FTT+siiMEOELuOL+LeN7Jw==",
            Remark = "管理员",
            SecurityStamp = "E3LEMZVTQRBJD2GDJXDNNJ7BF3GEEUBF",
            Enabled = true,
            CreationTime = DateTime.UtcNow,
            LastModificationTime = DateTime.UtcNow,
            CreatorId = SeedConst.UserId,
            LastModifierId = SeedConst.UserId,
            Version = "bdf72652-0120-4850-af9b-765a7d97a396"u8.ToArray()
        };
    }

    /// <summary>
    /// 创建测试用户
    /// </summary>
    private static User CreateTest() {
        return new User( SeedConst.TestUserId ) {
            UserName = "test",
            NormalizedUserName = "TEST",
            PasswordHash = "AQAAAAIAAYagAAAAEL/2eO55+SdIu+k/R3xYVem14slhnggeUGSakH3eaPKwlUBZ/E1r5f5xZVLTTdO9Bw==",
            Remark = "测试人员",
            SecurityStamp = "A7NSFR322R5LQXDUKQCLOWED7VW6QUA2",
            Enabled = true,
            CreationTime = DateTime.UtcNow,
            LastModificationTime = DateTime.UtcNow,
            CreatorId = SeedConst.UserId,
            LastModifierId = SeedConst.UserId,
            Version = "71ae3a69-088c-4dd1-b020-963b1779ad04"u8.ToArray()
        };
    }

    /// <summary>
    /// 创建默认用户角色
    /// </summary>
    public static IEnumerable<UserRole> CreateDefaultUserRoles() {
        return new[] {
            new UserRole( SeedConst.UserId, SeedConst.RoleId ),
            new UserRole( SeedConst.TestUserId, SeedConst.TestRoleId )
        };
    }
}