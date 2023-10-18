namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 应用程序数据种子
/// </summary>
public static class ApplicationSeed {
    /// <summary>
    /// 创建默认应用程序
    /// </summary>
    public static IEnumerable<Application> CreateDefaultApplications() {
        return new[] {
            new Application( SeedConst.ApplicationId ) {
                Code = "admin-ui",
                Name = "管理系统后台",
                Enabled = true,
                IsClient = true,
                AccessTokenLifetime = 3600,
                AllowOfflineAccess = true,
                AllowedCorsOrigins = "",
                RedirectUri = "https://localhost:16003/,http://localhost:16100/,https://localhost:12086/swagger/oauth2-redirect.html",
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "53c89d04-d5e7-43ea-860e-7fafa7cfc380"u8.ToArray()
            },
            new Application( SeedConst.ApiApplicationId ) {
                Code = "admin-api",
                Name = "管理系统Api",
                Enabled = true,
                IsApi = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "9ca734db-c97c-4454-acdb-80e8ddf0ed41"u8.ToArray()
            }
        };
    }
}