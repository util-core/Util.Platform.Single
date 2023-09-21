using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Util.Platform.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Permissions");

            migrationBuilder.CreateTable(
                name: "Application",
                schema: "Permissions",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "应用程序标识"),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "应用程序编码"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "应用程序名称"),
                    IsApi = table.Column<bool>(type: "bit", nullable: false, comment: "是否Api"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, comment: "启用"),
                    AllowedCorsOrigins = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "允许跨域来源"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationId)
                        .Annotation("SqlServer:Clustered", false);
                },
                comment: "应用程序");

            migrationBuilder.CreateTable(
                name: "Claim",
                schema: "Permissions",
                columns: table => new
                {
                    ClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "声明标识"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "声明名称"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "int", nullable: true, comment: "排序号"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.ClaimId)
                        .Annotation("SqlServer:Clustered", false);
                },
                comment: "声明");

            migrationBuilder.CreateTable(
                name: "CommonOperation",
                schema: "Permissions",
                columns: table => new
                {
                    OperationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "操作标识"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "操作名称"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "int", nullable: true, comment: "排序号"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonOperation", x => x.OperationId)
                        .Annotation("SqlServer:Clustered", false);
                },
                comment: "常用操作资源");

            migrationBuilder.CreateTable(
                name: "OperationApi",
                schema: "Permissions",
                columns: table => new
                {
                    OperationApiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "操作Api标识"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    OperationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "操作资源标识"),
                    ApiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Api资源标识"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationApi", x => x.OperationApiId)
                        .Annotation("SqlServer:Clustered", false);
                },
                comment: "操作Api");

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Permissions",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "角色标识"),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "父标识"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "路径"),
                    Level = table.Column<int>(type: "int", nullable: false, comment: "层级"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "int", nullable: true, comment: "排序号"),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "角色编码"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "角色名称"),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "标准化角色名称"),
                    Type = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "角色类型"),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false, comment: "管理员"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    PinYin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "拼音简码"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "租户标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId)
                        .Annotation("SqlServer:Clustered", false);
                },
                comment: "角色");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Permissions",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "用户标识"),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, comment: "用户名"),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, comment: "标准化用户名"),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, comment: "安全邮箱"),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, comment: "标准化邮箱"),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false, comment: "邮箱是否已确认"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, comment: "安全手机号"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false, comment: "手机号是否已确认"),
                    PasswordHash = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, comment: "密码散列"),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false, comment: "是否启用双因素认证"),
                    Enabled = table.Column<bool>(type: "bit", nullable: true, comment: "是否启用"),
                    DisabledTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "冻结时间"),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false, comment: "是否启用锁定"),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "锁定截止"),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: true, comment: "登录失败次数"),
                    LoginCount = table.Column<int>(type: "int", nullable: true, comment: "登录次数"),
                    RegisterIp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "注册Ip"),
                    LastLoginTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "上次登陆时间"),
                    LastLoginIp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "上次登陆Ip"),
                    CurrentLoginTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "本次登陆时间"),
                    CurrentLoginIp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "本次登陆Ip"),
                    SecurityStamp = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, comment: "安全戳"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "租户标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId)
                        .Annotation("SqlServer:Clustered", false);
                },
                comment: "用户");

            migrationBuilder.CreateTable(
                name: "Resource",
                schema: "Permissions",
                columns: table => new
                {
                    ResourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "资源标识"),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "父标识"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "路径"),
                    Level = table.Column<int>(type: "int", nullable: false, comment: "层级"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "int", nullable: true, comment: "排序号"),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "应用程序标识"),
                    Uri = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true, comment: "资源标识符"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "资源名称"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "资源类型"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    PinYin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "拼音简码"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Resource_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Permissions",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Resource_Resource_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Permissions",
                        principalTable: "Resource",
                        principalColumn: "ResourceId");
                },
                comment: "资源");

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "Permissions",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "用户标识"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "角色标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Permissions",
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Permissions",
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "用户角色");

            migrationBuilder.CreateTable(
                name: "Permission",
                schema: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "权限标识"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "角色标识"),
                    ResourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "资源标识"),
                    IsDeny = table.Column<bool>(type: "bit", nullable: false, comment: "拒绝"),
                    IsTemporary = table.Column<bool>(type: "bit", nullable: false, comment: "临时"),
                    ExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "到期时间"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "租户标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Permission_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalSchema: "Permissions",
                        principalTable: "Resource",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "权限");

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "Application",
                columns: new[] { "ApplicationId", "AllowedCorsOrigins", "Code", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsApi", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "Remark" },
                values: new object[,]
                {
                    { new Guid("0f5fb254-47a1-4e2f-b79a-c7ad1d226ab9"), null, "admin-api", new DateTime(2023, 9, 20, 17, 4, 44, 147, DateTimeKind.Utc).AddTicks(6402), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{}", true, false, new DateTime(2023, 9, 20, 17, 4, 44, 147, DateTimeKind.Utc).AddTicks(6403), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "管理系统Api", null },
                    { new Guid("9f6bc688-2634-4098-b622-4bde9a3ab5c4"), "https://localhost:12086", "api-swagger", new DateTime(2023, 9, 20, 17, 4, 44, 147, DateTimeKind.Utc).AddTicks(6411), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"IsClient\":true,\"AccessTokenLifetime\":3600,\"AllowOfflineAccess\":true,\"RedirectUri\":\"https://localhost:12086/swagger/oauth2-redirect.html\"}", false, false, new DateTime(2023, 9, 20, 17, 4, 44, 147, DateTimeKind.Utc).AddTicks(6411), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "Swagger UI - Util Platform Api", null },
                    { new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), "https://localhost:16003", "admin-ui", new DateTime(2023, 9, 20, 17, 4, 44, 147, DateTimeKind.Utc).AddTicks(6391), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"IsClient\":true,\"AccessTokenLifetime\":3600,\"AllowOfflineAccess\":true,\"RedirectUri\":\"https://localhost:16003/\"}", false, false, new DateTime(2023, 9, 20, 17, 4, 44, 147, DateTimeKind.Utc).AddTicks(6393), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "管理系统后台", null }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "Claim",
                columns: new[] { "ClaimId", "CreationTime", "CreatorId", "Enabled", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "Remark", "SortId" },
                values: new object[,]
                {
                    { new Guid("19af94f7-80a2-5d42-d432-278a23b10492"), new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8948), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8948), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "application_id", "应用程序标识", 7 },
                    { new Guid("1a331188-3318-a029-c8c8-71258c7041b2"), new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8932), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8933), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "name", "用户名", 3 },
                    { new Guid("27d23b13-0cb5-20aa-c65a-81bd90c35212"), new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8936), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8937), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "nickname", "昵称", 4 },
                    { new Guid("5b422322-b7f5-4081-e10a-fa96a85c5b86"), new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8920), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8921), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "sub", "用户标识", 1 },
                    { new Guid("70a9173d-2216-7bf6-2cbe-f0b2d38c524d"), new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8928), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8929), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "profile", "用户个人信息", 2 },
                    { new Guid("88a7eae0-3187-ac06-3766-8edf13d06776"), new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8944), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8944), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "phone_number", "手机号", 6 },
                    { new Guid("c38280ce-92f9-77be-1e17-87cd58c3fff1"), new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8940), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 148, DateTimeKind.Utc).AddTicks(8941), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "email", "电子邮件", 5 }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "CommonOperation",
                columns: new[] { "OperationId", "CreationTime", "CreatorId", "Enabled", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "Remark", "SortId" },
                values: new object[,]
                {
                    { new Guid("1f2a241b-cd39-a8f6-3f0b-8ba1429ee7d8"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7055), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7055), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "保存", null, 6 },
                    { new Guid("50621bb8-47e5-c255-f144-7d8fe125f9c5"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7038), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7038), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "创建", null, 2 },
                    { new Guid("5938e49c-a434-6fd8-f826-ca53914eb639"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7046), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7047), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "删除", null, 4 },
                    { new Guid("67c2e873-bd4c-8bf4-278d-1a47071c18ba"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7073), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7073), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "审核", null, 9 },
                    { new Guid("71bf64bc-d530-d5d9-fe18-a425c622e81b"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7062), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7062), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "禁用", null, 8 },
                    { new Guid("7de225c2-97f0-599f-392f-8c3c4f20424a"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7030), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7031), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "查看", null, 1 },
                    { new Guid("9fcddc9b-9c9f-9ef6-b9cc-dac52bdfce6d"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7051), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7051), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "管理", null, 5 },
                    { new Guid("a4f60b2a-69ed-47f3-42a8-488d87d7b3b8"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7058), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7059), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "启用", null, 7 },
                    { new Guid("be5e151c-750d-6c84-3f63-fb6b6e4d9c60"), new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7042), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2023, 9, 20, 17, 4, 44, 150, DateTimeKind.Utc).AddTicks(7043), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "更新", null, 3 }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "Resource",
                columns: new[] { "ResourceId", "ApplicationId", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "ParentId", "Path", "PinYin", "Remark", "SortId", "Type", "Uri" },
                values: new object[,]
                {
                    { new Guid("3493f51d-ac81-4f39-80ea-0acb02c9fee2"), null, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5788), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[\"sub\"]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5788), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "openid", null, "3493f51d-ac81-4f39-80ea-0acb02c9fee2,", null, "用户标识", 1, 5, "openid" },
                    { new Guid("cda87744-449d-4060-8f99-88c4223d103f"), null, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5797), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[\"profile\",\"name\"]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5797), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "profile", null, "cda87744-449d-4060-8f99-88c4223d103f,", null, "用户信息", 1, 5, "profile" }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "Role",
                columns: new[] { "RoleId", "Code", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsAdmin", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "NormalizedName", "ParentId", "Path", "PinYin", "Remark", "SortId", "TenantId", "Type" },
                values: new object[,]
                {
                    { new Guid("3465bc8f-dc86-46da-bb97-1721e257143c"), "test", new DateTime(2023, 9, 20, 17, 4, 44, 172, DateTimeKind.Utc).AddTicks(8649), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{}", false, false, new DateTime(2023, 9, 20, 17, 4, 44, 172, DateTimeKind.Utc).AddTicks(8650), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "测试人员", "测试人员", null, "3465bc8f-dc86-46da-bb97-1721e257143c,", "csry", "测试人员", 1, null, "Role" },
                    { new Guid("d5c3cbde-f2be-47ac-bc85-a329f79588f8"), "admin", new DateTime(2023, 9, 20, 17, 4, 44, 172, DateTimeKind.Utc).AddTicks(8630), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{}", true, false, new DateTime(2023, 9, 20, 17, 4, 44, 172, DateTimeKind.Utc).AddTicks(8633), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "管理员", "管理员", null, "d5c3cbde-f2be-47ac-bc85-a329f79588f8,", "gly", "管理员", 1, null, "Role" }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "User",
                columns: new[] { "UserId", "AccessFailedCount", "CreationTime", "CreatorId", "CurrentLoginIp", "CurrentLoginTime", "DisabledTime", "Email", "EmailConfirmed", "Enabled", "ExtraProperties", "IsDeleted", "LastLoginIp", "LastLoginTime", "LastModificationTime", "LastModifierId", "LockoutEnabled", "LockoutEnd", "LoginCount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisterIp", "Remark", "SecurityStamp", "TenantId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, new DateTime(2023, 9, 20, 17, 4, 44, 175, DateTimeKind.Utc).AddTicks(2525), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, null, null, null, false, true, "{}", false, null, null, new DateTime(2023, 9, 20, 17, 4, 44, 175, DateTimeKind.Utc).AddTicks(2530), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), false, null, null, null, "ADMIN", "AQAAAAEAACcQAAAAEP+Co27jHqc5JQ0LPfqcMbUtsrCHkZhK/oRC/xPysrV9FTT+siiMEOELuOL+LeN7Jw==", null, false, null, "管理员", "E3LEMZVTQRBJD2GDJXDNNJ7BF3GEEUBF", null, false, "admin" },
                    { new Guid("c7cc9ba2-74e2-43f2-8250-7b01e849b03a"), null, new DateTime(2023, 9, 20, 17, 4, 44, 175, DateTimeKind.Utc).AddTicks(2541), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, null, null, null, false, true, "{}", false, null, null, new DateTime(2023, 9, 20, 17, 4, 44, 175, DateTimeKind.Utc).AddTicks(2542), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), false, null, null, null, "TEST", "AQAAAAIAAYagAAAAEL/2eO55+SdIu+k/R3xYVem14slhnggeUGSakH3eaPKwlUBZ/E1r5f5xZVLTTdO9Bw==", null, false, null, "测试人员", "A7NSFR322R5LQXDUKQCLOWED7VW6QUA2", null, false, "test" }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "Resource",
                columns: new[] { "ResourceId", "ApplicationId", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "ParentId", "Path", "PinYin", "Remark", "SortId", "Type", "Uri" },
                values: new object[] { new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5716), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5717), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "系统管理", null, "ec9c35b4-3dfd-4cee-be70-9d83993b40e5,", "xtgl", "系统管理", 1, 1, null });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d5c3cbde-f2be-47ac-bc85-a329f79588f8"), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896") },
                    { new Guid("3465bc8f-dc86-46da-bb97-1721e257143c"), new Guid("c7cc9ba2-74e2-43f2-8250-7b01e849b03a") }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "Resource",
                columns: new[] { "ResourceId", "ApplicationId", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "ParentId", "Path", "PinYin", "Remark", "SortId", "Type", "Uri" },
                values: new object[,]
                {
                    { new Guid("1a01a8c3-1e6f-47d8-be75-b66da7f7a746"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5757), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5757), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 2, "角色", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "ec9c35b4-3dfd-4cee-be70-9d83993b40e5,1a01a8c3-1e6f-47d8-be75-b66da7f7a746,", "js", "角色", 4, 1, "/identity/role" },
                    { new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5729), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5729), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 2, "应用程序", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "ec9c35b4-3dfd-4cee-be70-9d83993b40e5,9412c649-2353-4f37-a178-21a66a7ad3bf,", "yycx", "应用程序", 1, 1, "/identity/application" },
                    { new Guid("a4c32fa8-f8eb-4ce9-a517-d96d431fcb04"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5775), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5775), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 2, "用户", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "ec9c35b4-3dfd-4cee-be70-9d83993b40e5,a4c32fa8-f8eb-4ce9-a517-d96d431fcb04,", "yh", "用户", 5, 1, "/identity/user" },
                    { new Guid("ccb74938-7e59-4532-a1ec-850ca75dd7b9"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5740), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5741), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 2, "声明", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "ec9c35b4-3dfd-4cee-be70-9d83993b40e5,ccb74938-7e59-4532-a1ec-850ca75dd7b9,", "sm", "声明", 2, 1, "/identity/claim" },
                    { new Guid("f85e2381-f85f-4978-aeaa-dd0a3106d1ab"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5748), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5749), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 2, "资源", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "ec9c35b4-3dfd-4cee-be70-9d83993b40e5,f85e2381-f85f-4978-aeaa-dd0a3106d1ab,", "zy", "资源", 3, 1, "/identity/resource" },
                    { new Guid("575a2e6e-6b3d-40ef-abd0-a820be29cc8f"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5825), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5826), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "更新", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, null, 3, 2, "application.update" },
                    { new Guid("73443ecd-fb73-4987-9a9d-cd69fc0881c0"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5802), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5803), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, null, 1, 2, "application.view" },
                    { new Guid("8f979359-a998-4c8e-83b7-b22815dab9a8"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5834), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5835), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, null, 4, 2, "application.delete" },
                    { new Guid("a7c889b7-4f7e-416c-a4e7-6694e61c4abd"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5808), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(5808), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, null, 2, 2, "application.create" }
                });

            migrationBuilder.InsertData(
                schema: "Permissions",
                table: "Permission",
                columns: new[] { "PermissionId", "CreationTime", "CreatorId", "ExpirationTime", "IsDeleted", "IsDeny", "IsTemporary", "LastModificationTime", "LastModifierId", "ResourceId", "RoleId", "TenantId" },
                values: new object[] { new Guid("8ba0d59a-ccc1-469c-8b15-a5867d4832b1"), new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(1366), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, false, false, false, new DateTime(2023, 9, 20, 17, 4, 44, 158, DateTimeKind.Utc).AddTicks(1370), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), new Guid("73443ecd-fb73-4987-9a9d-cd69fc0881c0"), new Guid("3465bc8f-dc86-46da-bb97-1721e257143c"), null });

            migrationBuilder.CreateIndex(
                name: "IX_Application_CreationTime",
                schema: "Permissions",
                table: "Application",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Claim_CreationTime",
                schema: "Permissions",
                table: "Claim",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CommonOperation_CreationTime",
                schema: "Permissions",
                table: "CommonOperation",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationApi_CreationTime",
                schema: "Permissions",
                table: "OperationApi",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_CreationTime",
                schema: "Permissions",
                table: "Permission",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_ResourceId",
                schema: "Permissions",
                table: "Permission",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ApplicationId",
                schema: "Permissions",
                table: "Resource",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_CreationTime",
                schema: "Permissions",
                table: "Resource",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ParentId",
                schema: "Permissions",
                table: "Resource",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreationTime",
                schema: "Permissions",
                table: "Role",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_User_CreationTime",
                schema: "Permissions",
                table: "User",
                column: "CreationTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "Permissions",
                table: "UserRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claim",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "CommonOperation",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "OperationApi",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "Permission",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "Resource",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "Application",
                schema: "Permissions");
        }
    }
}
