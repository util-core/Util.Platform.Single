namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 常用操作资源数据种子
/// </summary>
public static class CommonOperationSeed {
    /// <summary>
    /// 创建默认常用操作资源
    /// </summary>
    public static IEnumerable<CommonOperation> CreateDefaultOperations() {
        return new[] {
            new CommonOperation( "7DE225C2-97F0-599F-392F-8C3C4F20424A".ToGuid() ) {
                Name = "查看",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 1,
                Version = "aad31c30-9050-47bb-8181-05ed793e0f7f"u8.ToArray()
            },
            new CommonOperation( "50621BB8-47E5-C255-F144-7D8FE125F9C5".ToGuid() ) {
                Name = "创建",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 2,
                Version = "44e1f59a-a731-45a6-8d89-28d37b0d5d8c"u8.ToArray()
            },
            new CommonOperation( "BE5E151C-750D-6C84-3F63-FB6B6E4D9C60".ToGuid() ) {
                Name = "更新",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 3,
                Version = "ed0497be-6677-47b6-a4c1-55d979c897f4"u8.ToArray()
            },
            new CommonOperation( "5938E49C-A434-6FD8-F826-CA53914EB639".ToGuid() ) {
                Name = "删除",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 4,
                Version = "22c9160d-f4bf-488e-a7e8-135f5200e7f5"u8.ToArray()
            },
            new CommonOperation( "9FCDDC9B-9C9F-9EF6-B9CC-DAC52BDFCE6D".ToGuid() ) {
                Name = "管理",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 5,
                Version = "54507256-f43c-4365-a554-62dd468f7d35"u8.ToArray()
            },
            new CommonOperation( "1F2A241B-CD39-A8F6-3F0B-8BA1429EE7D8".ToGuid() ) {
                Name = "保存",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 6,
                Version = "27351aae-46bb-4efe-b6a5-65e9474701a6"u8.ToArray()
            },
            new CommonOperation( "A4F60B2A-69ED-47F3-42A8-488D87D7B3B8".ToGuid() ) {
                Name = "启用",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 7,
                Version = "82a106cf-e5ae-46c7-a5f4-25a460dac4c4"u8.ToArray()
            },
            new CommonOperation( "71BF64BC-D530-D5D9-FE18-A425C622E81B".ToGuid() ) {
                Name = "禁用",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 8,
                Version = "87dd55b6-d048-4286-96f2-4505ba6568c1"u8.ToArray()
            },
            new CommonOperation( "67C2E873-BD4C-8BF4-278D-1A47071C18BA".ToGuid() ) {
                Name = "审核",
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                SortId = 9,
                Version = "6654087a-0d96-4689-831e-0cadc2e5831e"u8.ToArray()
            }
        };
    }
}