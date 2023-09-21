namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 声明数据种子
/// </summary>
public static class ClaimSeed {
    /// <summary>
    /// 创建默认声明
    /// </summary>
    public static IEnumerable<Claim> CreateDefaultClaims() {
        return new[] {
            new Claim( "5b422322-b7f5-4081-e10a-fa96a85c5b86".ToGuid() ) {
                Name = "sub",
                Remark = "用户标识",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 1,
                Version = "9436d571-da73-4b7c-a60e-e98feb74652e"u8.ToArray()
            },
            new Claim( "70a9173d-2216-7bf6-2cbe-f0b2d38c524d".ToGuid() ) {
                Name = "profile",
                Remark = "用户个人信息",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 2,
                Version = "777d0bf4-315d-4680-8d88-0896aa1a89df"u8.ToArray()
            },
            new Claim( "1a331188-3318-a029-c8c8-71258c7041b2".ToGuid() ) {
                Name = "name",
                Remark = "用户名",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 3,
                Version = "74d0f7cc-4a17-4ed1-8116-c511ce75a1c4"u8.ToArray()
            },
            new Claim( "27d23b13-0cb5-20aa-c65a-81bd90c35212".ToGuid() ) {
                Name = "nickname",
                Remark = "昵称",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 4,
                Version = "31aceffa-2f14-4551-807d-9da70c4d809c"u8.ToArray()
            },
            new Claim( "c38280ce-92f9-77be-1e17-87cd58c3fff1".ToGuid() ) {
                Name = "email",
                Remark = "电子邮件",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 5,
                Version = "176080ce-b34c-449d-b025-81aeed6313d6"u8.ToArray()
            },
            new Claim( "88a7eae0-3187-ac06-3766-8edf13d06776".ToGuid() ) {
                Name = "phone_number",
                Remark = "手机号",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 6,
                Version = "c14657d6-8de6-434a-9f99-9dcef6a29950"u8.ToArray()
            },
            new Claim( "19af94f7-80a2-5d42-d432-278a23b10492".ToGuid() ) {
                Name = "application_id",
                Remark = "应用程序标识",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 7,
                Version = "dc0fc00c-d885-4274-b8b1-d9bfae682f5e"u8.ToArray()
            }
        };
    }
}