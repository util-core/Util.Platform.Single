namespace Util.Platform.Data.Seeds.Identity;

/// <summary>
/// 资源数据种子
/// </summary>
public static class ResourceSeed {
    /// <summary>
    /// 创建默认资源
    /// </summary>
    public static IEnumerable<Resource> CreateDefaultResources() {
        return new[] {
            new Resource( SeedConst.SystemResourceId,$"{SeedConst.SystemResourceId},",1 ) {
                ApplicationId = SeedConst.ApplicationId,
                Name = "系统管理",
                I18n = "menu.system",
                PinYin = "xtgl",
                Type = ResourceType.Module,
                SortId = 1,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "e738a96e-517e-480b-9fb7-5d2616888f1d"u8.ToArray()
            },
            new Resource( SeedConst.AppliationResourceId,$"{SeedConst.SystemResourceId},{SeedConst.AppliationResourceId},",2 ) {
                ApplicationId = SeedConst.ApplicationId,
                ParentId = SeedConst.SystemResourceId,
                Name = "应用程序",
                I18n = "identity.application",
                Icon = "laptop",
                PinYin = "yycx",
                Uri = "/identity/application",
                Type = ResourceType.Module,
                SortId = 1,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "7664ee42-1968-4b6a-93e6-851524eaa97c"u8.ToArray()
            },
            new Resource( SeedConst.ClaimResourceId,$"{SeedConst.SystemResourceId},{SeedConst.ClaimResourceId},",2 ) {
                ApplicationId = SeedConst.ApplicationId,
                ParentId = SeedConst.SystemResourceId,
                Name = "声明",
                I18n = "identity.claim",
                Icon = "idcard",
                PinYin = "sm",
                Uri = "/identity/claim",
                Type = ResourceType.Module,
                SortId = 2,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "44fd1a4e-49ab-4a5c-b7ec-f760ffaa37ba"u8.ToArray()
            },
            new Resource( SeedConst.ResourceId,$"{SeedConst.SystemResourceId},{SeedConst.ResourceId},",2 ) {
                ApplicationId = SeedConst.ApplicationId,
                ParentId = SeedConst.SystemResourceId,
                Name = "资源",
                I18n = "identity.resource",
                Icon = "apartment",
                PinYin = "zy",
                Uri = "/identity/resource",
                Type = ResourceType.Module,
                SortId = 3,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "881be306-9acc-4b8f-a638-1a43ed8b2f47"u8.ToArray()
            },
            new Resource( SeedConst.RoleResourceId,$"{SeedConst.SystemResourceId},{SeedConst.RoleResourceId},",2 ) {
                ApplicationId = SeedConst.ApplicationId,
                ParentId = SeedConst.SystemResourceId,
                Name = "角色",
                I18n = "identity.role",
                Icon = "team",
                PinYin = "js",
                Uri = "/identity/role",
                Type = ResourceType.Module,
                SortId = 4,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "a4fa46b0-cad1-4862-9388-1bdd8efd607d"u8.ToArray()
            },
            new Resource( SeedConst.UserResourceId,$"{SeedConst.SystemResourceId},{SeedConst.UserResourceId},",2 ) {
                ApplicationId = SeedConst.ApplicationId,
                ParentId = SeedConst.SystemResourceId,
                Name = "用户",
                I18n = "identity.user",
                Icon = "user",
                PinYin = "yh",
                Uri = "/identity/user",
                Type = ResourceType.Module,
                SortId = 5,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "75d51762-d517-452f-bf46-67cf0de9cd26"u8.ToArray()
            },
            new Resource( SeedConst.OpenIdResourceId,$"{SeedConst.OpenIdResourceId},",1 ) {
                Name = "openid",
                Remark = "用户标识",
                Uri = "openid",
                Type = ResourceType.Identity,
                SortId = 1,
                Enabled = true,
                Claims = new List<string>{"sub"},
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "68792f77-4aaa-4ea0-a1a8-e5c940070910"u8.ToArray()
            },
            new Resource( SeedConst.ProfileResourceId,$"{SeedConst.ProfileResourceId},",1 ) {
                Name = "profile",
                Remark = "用户信息",
                Uri = "profile",
                Type = ResourceType.Identity,
                SortId = 1,
                Enabled = true,
                Claims = new List<string>{"profile","name"},
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "5fe23db5-7020-4596-9f16-c92525212993"u8.ToArray()
            },
            new Resource( SeedConst.ViewApplicationOperationId,null,0 ) {
                ApplicationId = SeedConst.ApplicationId,
                Name = "查看",
                Uri = "application.view",
                ParentId = SeedConst.AppliationResourceId,
                SortId = 1,
                Type = ResourceType.Operation,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "cba920f3-3c7a-4483-b991-b44f7a0e49f0"u8.ToArray()
            },
            new Resource( SeedConst.CreateApplicationOperationId,null,0 ) {
                ApplicationId = SeedConst.ApplicationId,
                Name = "创建",
                Uri = "application.create",
                ParentId = SeedConst.AppliationResourceId,
                SortId = 2,
                Type = ResourceType.Operation,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "dd9a3566-1be4-435e-b9d4-ce9d947a5053"u8.ToArray()
            },
            new Resource( "575A2E6E-6B3D-40EF-ABD0-A820BE29CC8F".ToGuid(),null,0 ) {
                ApplicationId = SeedConst.ApplicationId,
                Name = "更新",
                Uri = "application.update",
                ParentId = SeedConst.AppliationResourceId,
                SortId = 3,
                Type = ResourceType.Operation,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "3beb8876-e584-46d8-b9fb-5eb17c51d62c"u8.ToArray()
            },
            new Resource( "8F979359-A998-4C8E-83B7-B22815DAB9A8".ToGuid(),null,0 ) {
                ApplicationId = SeedConst.ApplicationId,
                Name = "删除",
                Uri = "application.delete",
                ParentId = SeedConst.AppliationResourceId,
                SortId = 4,
                Type = ResourceType.Operation,
                Enabled = true,
                CreationTime = DateTime.UtcNow,
                LastModificationTime = DateTime.UtcNow,
                CreatorId = SeedConst.UserId,
                LastModifierId = SeedConst.UserId,
                Version = "8faf0bbe-51d7-4e87-a431-989972f094c7"u8.ToArray()
            }
        };
    }
}