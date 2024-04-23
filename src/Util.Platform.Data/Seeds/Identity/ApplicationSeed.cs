namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 应用程序数据种子
/// </summary>
public static class ApplicationSeed {
    /// <summary>
    /// 创建默认应用程序
    /// </summary>
    public static IEnumerable<Application> CreateDefaultApplications() {
        return [
            new Application( SeedConst.ApplicationId ) {
                Code = "admin",
                Name = "管理系统",
                Remark = "这是第一个默认的管理后台系统",
                Enabled = true,
                IsClient = true,
                AccessTokenLifetime = 3600,
                AllowedGrantType = GrantType.AuthorizationCode,
                AllowOfflineAccess = true,
                AllowedCorsOrigins = "",
                RedirectUri = "https://localhost:16003/,http://localhost:16100/,https://localhost:10086/swagger/oauth2-redirect.html,https://localhost:12086/swagger/oauth2-redirect.html",
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "53c89d04-d5e7-43ea-860e-7fafa7cfc380"u8.ToArray()
            }
        ];
    }
}