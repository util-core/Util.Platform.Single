using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Util.Platform.Data.Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "应用程序标识"),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "BLOB", nullable: true, comment: "版本号"),
                    Code = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false, comment: "应用程序编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false, comment: "应用程序名称"),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false, comment: "启用"),
                    AllowedCorsOrigins = table.Column<string>(type: "TEXT", nullable: true, comment: "允许跨域来源"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationId);
                },
                comment: "应用程序");

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    ClaimId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "声明标识"),
                    Version = table.Column<byte[]>(type: "BLOB", nullable: true, comment: "版本号"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false, comment: "声明名称"),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "INTEGER", nullable: true, comment: "排序号"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.ClaimId);
                },
                comment: "声明");

            migrationBuilder.CreateTable(
                name: "CommonOperation",
                columns: table => new
                {
                    OperationId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "操作标识"),
                    Version = table.Column<byte[]>(type: "BLOB", nullable: true, comment: "版本号"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "操作名称"),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "INTEGER", nullable: true, comment: "排序号"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonOperation", x => x.OperationId);
                },
                comment: "常用操作资源");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "角色标识"),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "BLOB", nullable: true, comment: "版本号"),
                    ParentId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "父标识"),
                    Path = table.Column<string>(type: "TEXT", nullable: true, comment: "路径"),
                    Level = table.Column<int>(type: "INTEGER", nullable: false, comment: "层级"),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "INTEGER", nullable: true, comment: "排序号"),
                    Code = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false, comment: "角色编码"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false, comment: "角色名称"),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false, comment: "标准化角色名称"),
                    Type = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false, comment: "角色类型"),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false, comment: "管理员"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    PinYin = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true, comment: "拼音简码"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否删除"),
                    TenantId = table.Column<string>(type: "TEXT", nullable: true, comment: "租户标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                },
                comment: "角色");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "用户标识"),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "BLOB", nullable: true, comment: "版本号"),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true, comment: "用户名"),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true, comment: "标准化用户名"),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true, comment: "安全邮箱"),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true, comment: "标准化邮箱"),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false, comment: "邮箱是否已确认"),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 64, nullable: true, comment: "安全手机号"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false, comment: "手机号是否已确认"),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: true, comment: "密码散列"),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否启用双因素认证"),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: true, comment: "是否启用"),
                    DisabledTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "冻结时间"),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否启用锁定"),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true, comment: "锁定截止"),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: true, comment: "登录失败次数"),
                    LoginCount = table.Column<int>(type: "INTEGER", nullable: true, comment: "登录次数"),
                    RegisterIp = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "注册Ip"),
                    LastLoginTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "上次登陆时间"),
                    LastLoginIp = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "上次登陆Ip"),
                    CurrentLoginTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "本次登陆时间"),
                    CurrentLoginIp = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "本次登陆Ip"),
                    SecurityStamp = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: true, comment: "安全戳"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否删除"),
                    TenantId = table.Column<string>(type: "TEXT", nullable: true, comment: "租户标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                },
                comment: "用户");

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ResourceId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "资源标识"),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true, comment: "扩展属性"),
                    Version = table.Column<byte[]>(type: "BLOB", nullable: true, comment: "版本号"),
                    ParentId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "父标识"),
                    Path = table.Column<string>(type: "TEXT", nullable: true, comment: "路径"),
                    Level = table.Column<int>(type: "INTEGER", nullable: false, comment: "层级"),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false, comment: "启用"),
                    SortId = table.Column<int>(type: "INTEGER", nullable: true, comment: "排序号"),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "应用程序标识"),
                    Uri = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true, comment: "资源标识符"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false, comment: "资源名称"),
                    Type = table.Column<int>(type: "INTEGER", nullable: false, comment: "资源类型"),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true, comment: "备注"),
                    PinYin = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true, comment: "拼音简码"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceId);
                    table.ForeignKey(
                        name: "FK_Resource_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Resource_Resource_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Resource",
                        principalColumn: "ResourceId");
                },
                comment: "资源");

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "用户标识"),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "角色标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "用户角色");

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "权限标识"),
                    Version = table.Column<byte[]>(type: "BLOB", nullable: true, comment: "版本号"),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "角色标识"),
                    ResourceId = table.Column<Guid>(type: "TEXT", nullable: false, comment: "资源标识"),
                    IsDeny = table.Column<bool>(type: "INTEGER", nullable: false, comment: "拒绝"),
                    IsTemporary = table.Column<bool>(type: "INTEGER", nullable: false, comment: "临时"),
                    ExpirationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "到期时间"),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "创建时间"),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "创建人标识"),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "最后修改时间"),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true, comment: "最后修改人标识"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, comment: "是否删除"),
                    TenantId = table.Column<string>(type: "TEXT", nullable: true, comment: "租户标识")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId);
                    table.ForeignKey(
                        name: "FK_Permission_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "权限");

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "ApplicationId", "AllowedCorsOrigins", "Code", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "Remark", "Version" },
                values: new object[] { new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), "", "admin", new DateTime(2024, 4, 15, 16, 26, 18, 637, DateTimeKind.Utc).AddTicks(3597), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"IsClient\":true,\"AccessTokenLifetime\":3600,\"AllowedGrantType\":2,\"AllowOfflineAccess\":true,\"RedirectUri\":\"https://localhost:16003/,http://localhost:16100/,https://localhost:10086/swagger/oauth2-redirect.html,https://localhost:12086/swagger/oauth2-redirect.html\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 637, DateTimeKind.Utc).AddTicks(3600), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "管理系统", "这是第一个默认的管理后台系统", new byte[] { 53, 51, 99, 56, 57, 100, 48, 52, 45, 100, 53, 101, 55, 45, 52, 51, 101, 97, 45, 56, 54, 48, 101, 45, 55, 102, 97, 102, 97, 55, 99, 102, 99, 51, 56, 48 } });

            migrationBuilder.InsertData(
                table: "Claim",
                columns: new[] { "ClaimId", "CreationTime", "CreatorId", "Enabled", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "Remark", "SortId", "Version" },
                values: new object[,]
                {
                    { new Guid("19af94f7-80a2-5d42-d432-278a23b10492"), new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7527), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7528), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "application_id", "应用程序标识", 7, new byte[] { 100, 99, 48, 102, 99, 48, 48, 99, 45, 100, 56, 56, 53, 45, 52, 50, 55, 52, 45, 98, 56, 98, 49, 45, 100, 57, 98, 102, 97, 101, 54, 56, 50, 102, 53, 101 } },
                    { new Guid("1a331188-3318-a029-c8c8-71258c7041b2"), new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7511), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7511), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "name", "用户名", 3, new byte[] { 55, 52, 100, 48, 102, 55, 99, 99, 45, 52, 97, 49, 55, 45, 52, 101, 100, 49, 45, 56, 49, 49, 54, 45, 99, 53, 49, 49, 99, 101, 55, 53, 97, 49, 99, 52 } },
                    { new Guid("27d23b13-0cb5-20aa-c65a-81bd90c35212"), new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7515), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7516), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "nickname", "昵称", 4, new byte[] { 51, 49, 97, 99, 101, 102, 102, 97, 45, 50, 102, 49, 52, 45, 52, 53, 53, 49, 45, 56, 48, 55, 100, 45, 57, 100, 97, 55, 48, 99, 52, 100, 56, 48, 57, 99 } },
                    { new Guid("5b422322-b7f5-4081-e10a-fa96a85c5b86"), new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7492), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7493), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "sub", "用户标识", 1, new byte[] { 57, 52, 51, 54, 100, 53, 55, 49, 45, 100, 97, 55, 51, 45, 52, 98, 55, 99, 45, 97, 54, 48, 101, 45, 101, 57, 56, 102, 101, 98, 55, 52, 54, 53, 50, 101 } },
                    { new Guid("70a9173d-2216-7bf6-2cbe-f0b2d38c524d"), new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7500), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7500), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "profile", "用户个人信息", 2, new byte[] { 55, 55, 55, 100, 48, 98, 102, 52, 45, 51, 49, 53, 100, 45, 52, 54, 56, 48, 45, 56, 100, 56, 56, 45, 48, 56, 57, 54, 97, 97, 49, 97, 56, 57, 100, 102 } },
                    { new Guid("88a7eae0-3187-ac06-3766-8edf13d06776"), new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7523), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7524), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "phone_number", "手机号", 6, new byte[] { 99, 49, 52, 54, 53, 55, 100, 54, 45, 56, 100, 101, 54, 45, 52, 51, 52, 97, 45, 57, 102, 57, 57, 45, 57, 100, 99, 101, 102, 54, 97, 50, 57, 57, 53, 48 } },
                    { new Guid("c38280ce-92f9-77be-1e17-87cd58c3fff1"), new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7519), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 638, DateTimeKind.Utc).AddTicks(7520), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "email", "电子邮件", 5, new byte[] { 49, 55, 54, 48, 56, 48, 99, 101, 45, 98, 51, 52, 99, 45, 52, 52, 57, 100, 45, 98, 48, 50, 53, 45, 56, 49, 97, 101, 101, 100, 54, 51, 49, 51, 100, 54 } }
                });

            migrationBuilder.InsertData(
                table: "CommonOperation",
                columns: new[] { "OperationId", "CreationTime", "CreatorId", "Enabled", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "Remark", "SortId", "Version" },
                values: new object[,]
                {
                    { new Guid("1f2a241b-cd39-a8f6-3f0b-8ba1429ee7d8"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(639), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(640), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "保存", null, 6, new byte[] { 50, 55, 51, 53, 49, 97, 97, 101, 45, 52, 54, 98, 98, 45, 52, 101, 102, 101, 45, 98, 54, 97, 53, 45, 54, 53, 101, 57, 52, 55, 52, 55, 48, 49, 97, 54 } },
                    { new Guid("50621bb8-47e5-c255-f144-7d8fe125f9c5"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(615), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(616), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "创建", null, 2, new byte[] { 52, 52, 101, 49, 102, 53, 57, 97, 45, 97, 55, 51, 49, 45, 52, 53, 97, 54, 45, 56, 100, 56, 57, 45, 50, 56, 100, 51, 55, 98, 48, 100, 53, 100, 56, 99 } },
                    { new Guid("5938e49c-a434-6fd8-f826-ca53914eb639"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(625), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(625), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "删除", null, 4, new byte[] { 50, 50, 99, 57, 49, 54, 48, 100, 45, 102, 52, 98, 102, 45, 52, 56, 56, 101, 45, 97, 55, 101, 56, 45, 49, 51, 53, 102, 53, 50, 48, 48, 101, 55, 102, 53 } },
                    { new Guid("67c2e873-bd4c-8bf4-278d-1a47071c18ba"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(651), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(652), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "审核", null, 9, new byte[] { 54, 54, 53, 52, 48, 56, 55, 97, 45, 48, 100, 57, 54, 45, 52, 54, 56, 57, 45, 56, 51, 49, 101, 45, 48, 99, 97, 100, 99, 50, 101, 53, 56, 51, 49, 101 } },
                    { new Guid("71bf64bc-d530-d5d9-fe18-a425c622e81b"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(647), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(648), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "禁用", null, 8, new byte[] { 56, 55, 100, 100, 53, 53, 98, 54, 45, 100, 48, 52, 56, 45, 52, 50, 56, 54, 45, 57, 54, 102, 50, 45, 52, 53, 48, 53, 98, 97, 54, 53, 54, 56, 99, 49 } },
                    { new Guid("7de225c2-97f0-599f-392f-8c3c4f20424a"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(607), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(608), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "查看", null, 1, new byte[] { 97, 97, 100, 51, 49, 99, 51, 48, 45, 57, 48, 53, 48, 45, 52, 55, 98, 98, 45, 56, 49, 56, 49, 45, 48, 53, 101, 100, 55, 57, 51, 101, 48, 102, 55, 102 } },
                    { new Guid("9fcddc9b-9c9f-9ef6-b9cc-dac52bdfce6d"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(635), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(635), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "管理", null, 5, new byte[] { 53, 52, 53, 48, 55, 50, 53, 54, 45, 102, 52, 51, 99, 45, 52, 51, 54, 53, 45, 97, 53, 53, 52, 45, 54, 50, 100, 100, 52, 54, 56, 102, 55, 100, 51, 53 } },
                    { new Guid("a4f60b2a-69ed-47f3-42a8-488d87d7b3b8"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(643), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(644), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "启用", null, 7, new byte[] { 56, 50, 97, 49, 48, 54, 99, 102, 45, 101, 53, 97, 101, 45, 52, 54, 99, 55, 45, 97, 53, 102, 52, 45, 50, 53, 97, 52, 54, 48, 100, 97, 99, 52, 99, 52 } },
                    { new Guid("be5e151c-750d-6c84-3f63-fb6b6e4d9c60"), new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(620), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, false, new DateTime(2024, 4, 15, 16, 26, 18, 640, DateTimeKind.Utc).AddTicks(620), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), "更新", null, 3, new byte[] { 101, 100, 48, 52, 57, 55, 98, 101, 45, 54, 54, 55, 55, 45, 52, 55, 98, 54, 45, 97, 52, 99, 49, 45, 53, 53, 100, 57, 55, 57, 99, 56, 57, 55, 102, 52 } }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "ResourceId", "ApplicationId", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "ParentId", "Path", "PinYin", "Remark", "SortId", "Type", "Uri", "Version" },
                values: new object[,]
                {
                    { new Guid("3493f51d-ac81-4f39-80ea-0acb02c9fee2"), null, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(50), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[\"sub\"]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(50), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "openid", null, "3493f51d-ac81-4f39-80ea-0acb02c9fee2,", null, "用户标识", 1, 5, "openid", new byte[] { 54, 56, 55, 57, 50, 102, 55, 55, 45, 52, 97, 97, 97, 45, 52, 101, 97, 48, 45, 97, 49, 97, 56, 45, 101, 53, 99, 57, 52, 48, 48, 55, 48, 57, 49, 48 } },
                    { new Guid("cda87744-449d-4060-8f99-88c4223d103f"), null, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(58), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[\"profile\",\"name\"]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(59), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "profile", null, "cda87744-449d-4060-8f99-88c4223d103f,", null, "用户信息", 1, 5, "profile", new byte[] { 53, 102, 101, 50, 51, 100, 98, 53, 45, 55, 48, 50, 48, 45, 52, 53, 57, 54, 45, 57, 102, 49, 54, 45, 99, 57, 50, 53, 50, 53, 50, 49, 50, 57, 57, 51 } }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "Code", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsAdmin", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "NormalizedName", "ParentId", "Path", "PinYin", "Remark", "SortId", "TenantId", "Type", "Version" },
                values: new object[,]
                {
                    { new Guid("3465bc8f-dc86-46da-bb97-1721e257143c"), "test", new DateTime(2024, 4, 15, 16, 26, 18, 661, DateTimeKind.Utc).AddTicks(9668), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{}", false, false, new DateTime(2024, 4, 15, 16, 26, 18, 661, DateTimeKind.Utc).AddTicks(9668), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "测试人员", "测试人员", null, "3465bc8f-dc86-46da-bb97-1721e257143c,", "csry", "测试人员", 1, null, "Role", new byte[] { 56, 102, 53, 57, 52, 97, 50, 53, 45, 48, 54, 97, 49, 45, 52, 97, 56, 48, 45, 56, 48, 55, 55, 45, 56, 100, 97, 54, 53, 101, 98, 51, 100, 101, 50, 48 } },
                    { new Guid("d5c3cbde-f2be-47ac-bc85-a329f79588f8"), "admin", new DateTime(2024, 4, 15, 16, 26, 18, 661, DateTimeKind.Utc).AddTicks(9643), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{}", true, false, new DateTime(2024, 4, 15, 16, 26, 18, 661, DateTimeKind.Utc).AddTicks(9647), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "管理员", "管理员", null, "d5c3cbde-f2be-47ac-bc85-a329f79588f8,", "gly", "管理员", 1, null, "Role", new byte[] { 57, 48, 101, 49, 102, 51, 102, 98, 45, 101, 102, 102, 100, 45, 52, 50, 57, 99, 45, 56, 54, 52, 54, 45, 53, 100, 50, 98, 97, 102, 99, 99, 101, 53, 101, 49 } }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "AccessFailedCount", "CreationTime", "CreatorId", "CurrentLoginIp", "CurrentLoginTime", "DisabledTime", "Email", "EmailConfirmed", "Enabled", "ExtraProperties", "IsDeleted", "LastLoginIp", "LastLoginTime", "LastModificationTime", "LastModifierId", "LockoutEnabled", "LockoutEnd", "LoginCount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisterIp", "Remark", "SecurityStamp", "TenantId", "TwoFactorEnabled", "UserName", "Version" },
                values: new object[,]
                {
                    { new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, new DateTime(2024, 4, 15, 16, 26, 18, 663, DateTimeKind.Utc).AddTicks(9984), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, null, null, null, false, true, "{}", false, null, null, new DateTime(2024, 4, 15, 16, 26, 18, 663, DateTimeKind.Utc).AddTicks(9985), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, null, null, null, "ADMIN", "AQAAAAEAACcQAAAAEP+Co27jHqc5JQ0LPfqcMbUtsrCHkZhK/oRC/xPysrV9FTT+siiMEOELuOL+LeN7Jw==", null, false, null, "管理员", "E3LEMZVTQRBJD2GDJXDNNJ7BF3GEEUBF", null, false, "admin", new byte[] { 98, 100, 102, 55, 50, 54, 53, 50, 45, 48, 49, 50, 48, 45, 52, 56, 53, 48, 45, 97, 102, 57, 98, 45, 55, 54, 53, 97, 55, 100, 57, 55, 97, 51, 57, 54 } },
                    { new Guid("c7cc9ba2-74e2-43f2-8250-7b01e849b03a"), null, new DateTime(2024, 4, 15, 16, 26, 18, 663, DateTimeKind.Utc).AddTicks(9995), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, null, null, null, false, true, "{}", false, null, null, new DateTime(2024, 4, 15, 16, 26, 18, 663, DateTimeKind.Utc).AddTicks(9995), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, null, null, null, "TEST", "AQAAAAIAAYagAAAAEL/2eO55+SdIu+k/R3xYVem14slhnggeUGSakH3eaPKwlUBZ/E1r5f5xZVLTTdO9Bw==", null, false, null, "测试人员", "A7NSFR322R5LQXDUKQCLOWED7VW6QUA2", null, false, "test", new byte[] { 55, 49, 97, 101, 51, 97, 54, 57, 45, 48, 56, 56, 99, 45, 52, 100, 100, 49, 45, 98, 48, 50, 48, 45, 57, 54, 51, 98, 49, 55, 55, 57, 97, 100, 48, 52 } }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "ResourceId", "ApplicationId", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "ParentId", "Path", "PinYin", "Remark", "SortId", "Type", "Uri", "Version" },
                values: new object[] { new Guid("3a36abfa-ec83-4f40-a2ad-a0a49c811d6a"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9889), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"Group\":false,\"HideInBreadcrumb\":true,\"I18n\":\"menu.main\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9890), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 1, "主导航", null, "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,", "zdh", null, 1, 1, null, new byte[] { 53, 55, 52, 68, 48, 52, 66, 56, 45, 51, 48, 65, 66, 45, 52, 51, 49, 68, 45, 66, 67, 57, 51, 45, 48, 56, 69, 53, 54, 54, 65, 49, 68, 49, 57, 66 } });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d5c3cbde-f2be-47ac-bc85-a329f79588f8"), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896") },
                    { new Guid("3465bc8f-dc86-46da-bb97-1721e257143c"), new Guid("c7cc9ba2-74e2-43f2-8250-7b01e849b03a") }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "ResourceId", "ApplicationId", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "ParentId", "Path", "PinYin", "Remark", "SortId", "Type", "Uri", "Version" },
                values: new object[,]
                {
                    { new Guid("d861923e-ec0a-4347-a121-c8d1d7e6b489"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9901), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"menu.dashboard\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9902), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 2, "仪表盘", new Guid("3a36abfa-ec83-4f40-a2ad-a0a49c811d6a"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,d861923e-ec0a-4347-a121-c8d1d7e6b489,", "ybp", null, 1, 1, null, new byte[] { 70, 70, 53, 68, 55, 68, 51, 51, 45, 54, 56, 69, 67, 45, 52, 57, 66, 66, 45, 66, 57, 57, 67, 45, 49, 49, 50, 57, 51, 49, 51, 53, 66, 67, 48, 67 } },
                    { new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9927), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"menu.system\",\"Icon\":\"safety-certificate\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9927), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 2, "系统管理", new Guid("3a36abfa-ec83-4f40-a2ad-a0a49c811d6a"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,", "xtgl", null, 2, 1, null, new byte[] { 101, 55, 51, 56, 97, 57, 54, 101, 45, 53, 49, 55, 101, 45, 52, 56, 48, 98, 45, 57, 102, 98, 55, 45, 53, 100, 50, 54, 49, 54, 56, 56, 56, 102, 49, 100 } },
                    { new Guid("1a01a8c3-1e6f-47d8-be75-b66da7f7a746"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(30), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"identity.role\",\"Icon\":\"team\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(31), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 3, "角色", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,1a01a8c3-1e6f-47d8-be75-b66da7f7a746,", "js", null, 5, 1, "/identity/role", new byte[] { 97, 52, 102, 97, 52, 54, 98, 48, 45, 99, 97, 100, 49, 45, 52, 56, 54, 50, 45, 57, 51, 56, 56, 45, 49, 98, 100, 100, 56, 101, 102, 100, 54, 48, 55, 100 } },
                    { new Guid("316ca95f-c920-47cb-b93b-12e13e26f9f8"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9911), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"menu.dashboard.monitor\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9911), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 3, "监控页", new Guid("d861923e-ec0a-4347-a121-c8d1d7e6b489"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,d861923e-ec0a-4347-a121-c8d1d7e6b489,316ca95f-c920-47cb-b93b-12e13e26f9f8,", "ybp", null, 1, 1, "/dashboard/monitor", new byte[] { 50, 70, 53, 56, 53, 70, 49, 55, 45, 50, 52, 70, 48, 45, 52, 70, 70, 49, 45, 66, 57, 66, 49, 45, 49, 49, 53, 57, 65, 53, 70, 68, 51, 70, 67, 65 } },
                    { new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9938), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"identity.application\",\"Icon\":\"laptop\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9938), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 3, "应用程序", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,9412c649-2353-4f37-a178-21a66a7ad3bf,", "yycx", null, 1, 1, "/identity/application", new byte[] { 55, 54, 54, 52, 101, 101, 52, 50, 45, 49, 57, 54, 56, 45, 52, 98, 54, 97, 45, 57, 51, 101, 54, 45, 56, 53, 49, 53, 50, 52, 101, 97, 97, 57, 55, 99 } },
                    { new Guid("a4c32fa8-f8eb-4ce9-a517-d96d431fcb04"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(21), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"identity.user\",\"Icon\":\"user\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(21), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 3, "用户", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,a4c32fa8-f8eb-4ce9-a517-d96d431fcb04,", "yh", null, 4, 1, "/identity/user", new byte[] { 55, 53, 100, 53, 49, 55, 54, 50, 45, 100, 53, 49, 55, 45, 52, 53, 50, 102, 45, 98, 102, 52, 54, 45, 54, 55, 99, 102, 48, 100, 101, 57, 99, 100, 50, 54 } },
                    { new Guid("a7c0376a-b558-482d-998e-15ee1f1ac45f"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(39), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsHide\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(40), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 3, "权限", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,a7c0376a-b558-482d-998e-15ee1f1ac45f,", "qx", null, 5, 1, null, new byte[] { 67, 50, 66, 55, 51, 53, 65, 55, 45, 52, 66, 54, 48, 45, 52, 56, 56, 68, 45, 57, 69, 54, 68, 45, 49, 53, 69, 69, 54, 50, 65, 70, 66, 57, 49, 49 } },
                    { new Guid("ccb74938-7e59-4532-a1ec-850ca75dd7b9"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9947), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"identity.claim\",\"Icon\":\"idcard\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9948), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 3, "声明", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,ccb74938-7e59-4532-a1ec-850ca75dd7b9,", "sm", null, 2, 1, "/identity/claim", new byte[] { 52, 52, 102, 100, 49, 97, 52, 101, 45, 52, 57, 97, 98, 45, 52, 97, 53, 99, 45, 98, 55, 101, 99, 45, 102, 55, 54, 48, 102, 102, 97, 97, 51, 55, 98, 97 } },
                    { new Guid("f85e2381-f85f-4978-aeaa-dd0a3106d1ab"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9956), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"I18n\":\"identity.resource\",\"Icon\":\"apartment\"}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9957), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 3, "资源", new Guid("ec9c35b4-3dfd-4cee-be70-9d83993b40e5"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,f85e2381-f85f-4978-aeaa-dd0a3106d1ab,", "zy", null, 3, 1, "/identity/resource", new byte[] { 56, 56, 49, 98, 101, 51, 48, 54, 45, 57, 97, 99, 99, 45, 52, 98, 56, 102, 45, 97, 54, 51, 56, 45, 49, 97, 52, 51, 101, 100, 56, 98, 50, 102, 52, 55 } },
                    { new Guid("0088b0bd-6210-4e65-ae75-a642a5417809"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(117), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(118), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("ccb74938-7e59-4532-a1ec-850ca75dd7b9"), null, null, "删除声明", 4, 2, "claim.delete", new byte[] { 69, 67, 57, 67, 51, 53, 66, 52, 45, 51, 68, 70, 68, 45, 52, 67, 69, 69, 45, 66, 69, 55, 48, 45, 57, 68, 56, 51, 57, 57, 51, 66, 52, 48, 69, 53 } },
                    { new Guid("1fc74685-c1d4-4ba9-8b81-04cf4b5ae8d0"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9977), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsHide\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9977), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 4, "操作资源", new Guid("f85e2381-f85f-4978-aeaa-dd0a3106d1ab"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,f85e2381-f85f-4978-aeaa-dd0a3106d1ab,1fc74685-c1d4-4ba9-8b81-04cf4b5ae8d0,", "czzy", null, 2, 1, null, new byte[] { 50, 66, 67, 65, 69, 67, 67, 49, 45, 52, 68, 54, 53, 45, 52, 66, 68, 55, 45, 56, 69, 66, 52, 45, 49, 52, 67, 55, 49, 69, 48, 51, 53, 67, 70, 65 } },
                    { new Guid("24afa389-0230-40b0-9795-cf38db05ad18"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(105), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(106), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("ccb74938-7e59-4532-a1ec-850ca75dd7b9"), null, null, "创建声明", 2, 2, "claim.create", new byte[] { 51, 52, 54, 53, 66, 67, 56, 70, 45, 68, 67, 56, 54, 45, 52, 54, 68, 65, 45, 66, 66, 57, 55, 45, 49, 55, 50, 49, 69, 50, 53, 55, 49, 52, 51, 67 } },
                    { new Guid("2f60a136-5e31-43d9-81e7-104993080280"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(289), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(289), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("a4c32fa8-f8eb-4ce9-a517-d96d431fcb04"), null, null, "查看用户", 1, 2, "user.view", new byte[] { 48, 51, 57, 56, 49, 48, 55, 49, 45, 50, 53, 54, 67, 45, 52, 55, 53, 56, 45, 66, 57, 65, 50, 45, 49, 48, 53, 69, 56, 69, 48, 51, 48, 67, 67, 51 } },
                    { new Guid("414d9bb9-aca4-4496-9ffc-15f917e2d3d5"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(350), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(350), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "授予操作权限", new Guid("a7c0376a-b558-482d-998e-15ee1f1ac45f"), null, null, "授予操作权限", 2, 2, "permission.grantOperation", new byte[] { 51, 65, 55, 48, 55, 57, 66, 68, 45, 67, 66, 57, 66, 45, 52, 65, 66, 66, 45, 56, 66, 52, 52, 45, 49, 53, 70, 68, 65, 68, 69, 53, 67, 51, 49, 53 } },
                    { new Guid("4ebf8aeb-130a-40de-a098-16d138e6638d"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(368), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(368), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "拒绝Api权限", new Guid("a7c0376a-b558-482d-998e-15ee1f1ac45f"), null, null, "拒绝Api权限", 5, 2, "permission.denyApi", new byte[] { 54, 68, 69, 70, 68, 57, 53, 69, 45, 52, 51, 51, 65, 45, 52, 50, 49, 50, 45, 65, 57, 53, 68, 45, 49, 54, 69, 50, 68, 65, 67, 69, 54, 51, 66, 66 } },
                    { new Guid("545db6bb-d65a-4ca1-9bed-1174f40f4271"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(313), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(314), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("1a01a8c3-1e6f-47d8-be75-b66da7f7a746"), null, null, "创建角色", 2, 2, "role.create", new byte[] { 52, 53, 53, 66, 68, 70, 54, 53, 45, 55, 51, 67, 70, 45, 52, 53, 65, 51, 45, 57, 65, 56, 51, 45, 49, 49, 56, 65, 51, 51, 67, 68, 56, 65, 65, 48 } },
                    { new Guid("575a2e6e-6b3d-40ef-abd0-a820be29cc8f"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(81), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(82), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "更新", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, "更新应用程序", 3, 2, "application.update", new byte[] { 51, 98, 101, 98, 56, 56, 55, 54, 45, 101, 53, 56, 52, 45, 52, 54, 100, 56, 45, 98, 57, 102, 98, 45, 53, 101, 98, 49, 55, 99, 53, 49, 100, 54, 50, 99 } },
                    { new Guid("5b47784d-ae87-44fe-a5b5-113003324bbf"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(308), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(308), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("1a01a8c3-1e6f-47d8-be75-b66da7f7a746"), null, null, "查看角色", 1, 2, "role.view", new byte[] { 57, 66, 67, 54, 50, 54, 53, 69, 45, 54, 68, 68, 52, 45, 52, 65, 48, 70, 45, 57, 57, 54, 56, 45, 49, 49, 53, 54, 51, 67, 68, 52, 54, 52, 69, 68 } },
                    { new Guid("637534d1-0b4f-4dde-8b8f-16766bddc7f7"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(362), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(362), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "授予Api权限", new Guid("a7c0376a-b558-482d-998e-15ee1f1ac45f"), null, null, "授予Api权限", 4, 2, "permission.grantApi", new byte[] { 57, 68, 49, 70, 51, 50, 67, 52, 45, 53, 51, 54, 51, 45, 52, 68, 70, 48, 45, 65, 55, 53, 48, 45, 49, 54, 56, 55, 70, 49, 52, 51, 67, 50, 57, 67 } },
                    { new Guid("73443ecd-fb73-4987-9a9d-cd69fc0881c0"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(66), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(66), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, "查看应用程序", 1, 2, "application.view", new byte[] { 99, 98, 97, 57, 50, 48, 102, 51, 45, 51, 99, 55, 97, 45, 52, 52, 56, 51, 45, 98, 57, 57, 49, 45, 98, 52, 52, 102, 55, 97, 48, 101, 52, 57, 102, 48 } },
                    { new Guid("8917e9e0-9e85-460e-88ba-704a697f6e3e"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(99), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(100), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("ccb74938-7e59-4532-a1ec-850ca75dd7b9"), null, null, "查看声明", 1, 2, "claim.view", new byte[] { 56, 66, 65, 48, 68, 53, 57, 65, 45, 67, 67, 67, 49, 45, 52, 54, 57, 67, 45, 56, 66, 49, 53, 45, 65, 53, 56, 54, 55, 68, 52, 56, 51, 50, 66, 49 } },
                    { new Guid("8f979359-a998-4c8e-83b7-b22815dab9a8"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(87), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(87), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, "删除应用程序", 4, 2, "application.delete", new byte[] { 56, 102, 97, 102, 48, 98, 98, 101, 45, 53, 49, 100, 55, 45, 52, 101, 56, 55, 45, 97, 52, 51, 49, 45, 57, 56, 57, 57, 55, 50, 102, 48, 57, 52, 99, 55 } },
                    { new Guid("914dc6fd-0c75-4ac0-821f-b7846ba15a0d"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(111), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(112), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "保存", new Guid("ccb74938-7e59-4532-a1ec-850ca75dd7b9"), null, null, "保存声明", 3, 2, "claim.save", new byte[] { 65, 52, 67, 51, 50, 70, 65, 56, 45, 70, 56, 69, 66, 45, 52, 67, 69, 57, 45, 65, 53, 49, 55, 45, 68, 57, 54, 68, 52, 51, 49, 70, 67, 66, 48, 52 } },
                    { new Guid("9c73ca2b-0412-4f8d-935f-047d6e264334"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9987), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsHide\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9987), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 4, "Api资源", new Guid("f85e2381-f85f-4978-aeaa-dd0a3106d1ab"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,f85e2381-f85f-4978-aeaa-dd0a3106d1ab,9c73ca2b-0412-4f8d-935f-047d6e264334,", "apizy", null, 3, 1, null, new byte[] { 48, 56, 65, 48, 56, 67, 57, 53, 45, 50, 56, 48, 69, 45, 52, 56, 65, 52, 45, 65, 50, 65, 50, 45, 48, 52, 57, 48, 66, 51, 55, 49, 55, 52, 53, 67 } },
                    { new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9966), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsHide\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9967), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 4, "模块资源", new Guid("f85e2381-f85f-4978-aeaa-dd0a3106d1ab"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,f85e2381-f85f-4978-aeaa-dd0a3106d1ab,a6769fb3-1e3b-4fc4-b04c-f0338495dbed,", "mkzy", null, 1, 1, null, new byte[] { 48, 49, 50, 67, 52, 55, 69, 52, 45, 52, 54, 49, 50, 45, 52, 66, 54, 68, 45, 56, 65, 50, 68, 45, 48, 69, 54, 67, 66, 51, 55, 66, 66, 70, 49, 70 } },
                    { new Guid("a7c889b7-4f7e-416c-a4e7-6694e61c4abd"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(75), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(75), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("9412c649-2353-4f37-a178-21a66a7ad3bf"), null, null, "创建应用程序", 2, 2, "application.create", new byte[] { 100, 100, 57, 97, 51, 53, 54, 54, 45, 49, 98, 101, 52, 45, 52, 51, 53, 101, 45, 98, 57, 100, 52, 45, 99, 101, 57, 100, 57, 52, 55, 97, 53, 48, 53, 51 } },
                    { new Guid("b3434421-1ac6-4f4b-8bed-04acccd8c91c"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9996), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsHide\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(9997), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 4, "身份资源", new Guid("f85e2381-f85f-4978-aeaa-dd0a3106d1ab"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,f85e2381-f85f-4978-aeaa-dd0a3106d1ab,b3434421-1ac6-4f4b-8bed-04acccd8c91c,", "sfzy", null, 4, 1, null, new byte[] { 52, 70, 51, 50, 57, 50, 48, 50, 45, 68, 52, 49, 49, 45, 52, 70, 70, 54, 45, 66, 52, 53, 66, 45, 48, 53, 49, 49, 66, 67, 65, 55, 57, 52, 65, 51 } },
                    { new Guid("b84e8744-8a93-45a6-9dc4-16438631e1b1"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(356), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(357), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "拒绝操作权限", new Guid("a7c0376a-b558-482d-998e-15ee1f1ac45f"), null, null, "拒绝操作权限", 3, 2, "permission.denyOperation", new byte[] { 56, 55, 48, 57, 48, 55, 68, 52, 45, 50, 67, 67, 50, 45, 52, 52, 55, 49, 45, 56, 66, 67, 66, 45, 49, 54, 52, 57, 56, 48, 48, 49, 54, 51, 51, 48 } },
                    { new Guid("bffbfcdb-b805-4bca-add3-7a99e584d3a8"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(11), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsHide\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(12), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 4, "常用操作管理", new Guid("f85e2381-f85f-4978-aeaa-dd0a3106d1ab"), "3a36abfa-ec83-4f40-a2ad-a0a49c811d6a,ec9c35b4-3dfd-4cee-be70-9d83993b40e5,f85e2381-f85f-4978-aeaa-dd0a3106d1ab,bffbfcdb-b805-4bca-add3-7a99e584d3a8,", "cyczgl", null, 9, 1, null, new byte[] { 53, 55, 53, 65, 57, 49, 65, 50, 45, 70, 65, 55, 55, 45, 52, 66, 54, 48, 45, 56, 54, 54, 51, 45, 48, 49, 69, 68, 55, 54, 50, 55, 67, 49, 48, 66 } },
                    { new Guid("c003a8ea-fc54-446f-b6bd-106e50ad0470"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(301), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(301), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("a4c32fa8-f8eb-4ce9-a517-d96d431fcb04"), null, null, "删除用户", 3, 2, "user.delete", new byte[] { 49, 48, 54, 68, 54, 70, 67, 69, 45, 51, 56, 66, 66, 45, 52, 55, 70, 67, 45, 65, 56, 48, 56, 45, 49, 48, 57, 68, 52, 65, 66, 69, 48, 70, 50, 51 } },
                    { new Guid("c25a16b1-cece-46b3-8414-12a8491afb06"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(337), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(338), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "用户设置", new Guid("1a01a8c3-1e6f-47d8-be75-b66da7f7a746"), null, null, "角色用户设置", 5, 2, "role.userSettings", new byte[] { 49, 53, 69, 67, 53, 68, 50, 70, 45, 56, 50, 56, 65, 45, 52, 68, 66, 66, 45, 57, 70, 54, 56, 45, 49, 50, 65, 65, 56, 50, 52, 54, 70, 70, 56, 70 } },
                    { new Guid("dc125bea-29d8-448d-bbd1-119928d02bc5"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(324), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(325), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "更新", new Guid("1a01a8c3-1e6f-47d8-be75-b66da7f7a746"), null, null, "更新角色", 3, 2, "role.update", new byte[] { 51, 68, 52, 51, 53, 51, 50, 48, 45, 66, 70, 56, 65, 45, 52, 55, 70, 56, 45, 66, 67, 57, 51, 45, 49, 49, 66, 68, 67, 50, 50, 50, 56, 54, 70, 50 } },
                    { new Guid("de8b4989-5568-47a1-bc3b-12b7c0b54784"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(344), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(345), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "权限设置", new Guid("a7c0376a-b558-482d-998e-15ee1f1ac45f"), null, null, "权限设置", 1, 2, "permission.view", new byte[] { 70, 67, 55, 49, 69, 55, 57, 51, 45, 67, 54, 67, 54, 45, 52, 55, 49, 66, 45, 65, 51, 50, 48, 45, 49, 51, 48, 68, 69, 55, 67, 57, 65, 54, 56, 51 } },
                    { new Guid("f9431293-3758-4737-9030-11ea5f8eec35"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(331), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(331), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("1a01a8c3-1e6f-47d8-be75-b66da7f7a746"), null, null, "删除角色", 4, 2, "role.delete", new byte[] { 69, 68, 55, 57, 51, 65, 56, 55, 45, 68, 49, 69, 55, 45, 52, 57, 70, 66, 45, 66, 70, 54, 57, 45, 49, 50, 49, 68, 49, 49, 68, 48, 54, 50, 66, 70 } },
                    { new Guid("ffd031b3-9091-4d6a-b913-10677ee96b39"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(295), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(295), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("a4c32fa8-f8eb-4ce9-a517-d96d431fcb04"), null, null, "创建用户", 2, 2, "user.create", new byte[] { 54, 50, 66, 70, 66, 48, 70, 48, 45, 68, 56, 48, 56, 45, 52, 65, 53, 56, 45, 57, 68, 56, 55, 45, 49, 48, 54, 65, 53, 65, 50, 66, 57, 54, 55, 67 } }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "PermissionId", "CreationTime", "CreatorId", "ExpirationTime", "IsDeleted", "IsDeny", "IsTemporary", "LastModificationTime", "LastModifierId", "ResourceId", "RoleId", "TenantId", "Version" },
                values: new object[] { new Guid("8ba0d59a-ccc1-469c-8b15-a5867d4832b1"), new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(6326), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), null, false, false, false, new DateTime(2024, 4, 15, 16, 26, 18, 647, DateTimeKind.Utc).AddTicks(6328), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), new Guid("73443ecd-fb73-4987-9a9d-cd69fc0881c0"), new Guid("3465bc8f-dc86-46da-bb97-1721e257143c"), null, new byte[] { 100, 53, 100, 48, 98, 49, 101, 48, 45, 50, 56, 102, 100, 45, 52, 57, 52, 100, 45, 56, 51, 98, 53, 45, 55, 100, 50, 99, 56, 55, 49, 98, 100, 97, 48, 97 } });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "ResourceId", "ApplicationId", "CreationTime", "CreatorId", "Enabled", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Level", "Name", "ParentId", "Path", "PinYin", "Remark", "SortId", "Type", "Uri", "Version" },
                values: new object[,]
                {
                    { new Guid("09a52bd1-997c-483a-9026-01f306e2cc84"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(199), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(200), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("bffbfcdb-b805-4bca-add3-7a99e584d3a8"), null, null, "查看常用操作", 1, 2, "commonOperation.view", new byte[] { 48, 49, 53, 65, 52, 56, 67, 51, 45, 52, 52, 51, 67, 45, 52, 69, 50, 70, 45, 57, 50, 51, 50, 45, 48, 49, 70, 52, 52, 68, 55, 55, 66, 69, 70, 54 } },
                    { new Guid("0b782400-52c0-413a-8bbb-caffe8e902b0"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(131), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(131), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), null, null, "创建模块资源", 1, 2, "module.create", new byte[] { 69, 54, 65, 48, 70, 50, 56, 53, 45, 48, 67, 53, 70, 45, 52, 52, 54, 48, 45, 56, 68, 65, 53, 45, 53, 69, 54, 53, 68, 50, 50, 70, 53, 69, 66, 68 } },
                    { new Guid("1766b64d-1926-4d3b-9da8-2dc7453df41a"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(137), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(137), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "启用", new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), null, null, "启用模块资源", 1, 2, "module.enable", new byte[] { 57, 68, 67, 65, 65, 50, 48, 51, 45, 51, 53, 49, 51, 45, 52, 51, 70, 54, 45, 57, 56, 57, 50, 45, 48, 50, 51, 67, 50, 50, 69, 54, 65, 49, 57, 49 } },
                    { new Guid("1bb3da10-8de0-48d0-b48c-0cc5d9110575"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(229), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(230), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("9c73ca2b-0412-4f8d-935f-047d6e264334"), null, null, "创建Api资源", 2, 2, "apiResource.create", new byte[] { 66, 51, 57, 48, 70, 67, 53, 66, 45, 56, 54, 48, 48, 45, 52, 48, 65, 66, 45, 65, 57, 57, 55, 45, 48, 67, 69, 51, 66, 65, 55, 65, 68, 57, 50, 50 } },
                    { new Guid("2033d9f9-e836-4767-a710-ad7e589f4da9"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(156), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(157), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), null, null, "删除模块资源", 1, 2, "module.delete", new byte[] { 66, 69, 68, 49, 67, 69, 50, 50, 45, 55, 69, 67, 56, 45, 52, 52, 69, 66, 45, 66, 54, 52, 54, 45, 49, 65, 57, 56, 52, 54, 66, 51, 67, 54, 50, 50 } },
                    { new Guid("22029026-de32-483c-be42-0d67c8313195"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(240), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(240), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "启用", new Guid("9c73ca2b-0412-4f8d-935f-047d6e264334"), null, null, "启用Api资源", 4, 2, "apiResource.enable", new byte[] { 51, 49, 56, 57, 69, 57, 48, 65, 45, 68, 49, 57, 50, 45, 52, 65, 67, 51, 45, 66, 65, 54, 49, 45, 48, 68, 54, 57, 67, 53, 67, 54, 67, 69, 48, 54 } },
                    { new Guid("3511c3f2-d444-4f20-8c48-023e9d1aec3a"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(217), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(217), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("bffbfcdb-b805-4bca-add3-7a99e584d3a8"), null, null, "删除常用操作", 4, 2, "commonOperation.delete", new byte[] { 68, 52, 53, 52, 52, 55, 53, 57, 45, 52, 54, 49, 67, 45, 52, 56, 48, 51, 45, 65, 66, 67, 70, 45, 48, 50, 53, 68, 70, 52, 48, 48, 66, 57, 68, 53 } },
                    { new Guid("376f621f-bab1-4ec2-a688-01fe1877e842"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(205), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(206), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("bffbfcdb-b805-4bca-add3-7a99e584d3a8"), null, null, "创建常用操作", 2, 2, "commonOperation.create", new byte[] { 67, 50, 50, 65, 51, 66, 51, 65, 45, 50, 69, 67, 50, 45, 52, 55, 50, 55, 45, 56, 49, 49, 70, 45, 48, 50, 48, 55, 52, 65, 68, 52, 48, 65, 51, 55 } },
                    { new Guid("4a0b65e8-7145-48c4-a400-18934a90ebf7"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(174), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(175), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("1fc74685-c1d4-4ba9-8b81-04cf4b5ae8d0"), null, null, "查看操作资源", 1, 2, "operation.view", new byte[] { 56, 55, 65, 51, 67, 55, 55, 68, 45, 48, 48, 66, 56, 45, 52, 53, 69, 57, 45, 56, 56, 54, 68, 45, 48, 49, 50, 57, 56, 48, 65, 55, 53, 52, 57, 67 } },
                    { new Guid("4a672a64-ede1-4356-b19b-020fe1d713c6"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(211), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(211), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "保存", new Guid("bffbfcdb-b805-4bca-add3-7a99e584d3a8"), null, null, "保存常用操作", 3, 2, "commonOperation.save", new byte[] { 48, 55, 69, 57, 56, 51, 68, 57, 45, 50, 65, 48, 66, 45, 52, 48, 54, 66, 45, 57, 50, 54, 51, 45, 48, 50, 49, 66, 55, 68, 53, 53, 54, 66, 52, 69 } },
                    { new Guid("4bb75118-6395-4db4-a031-0ce63ba1fff7"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(235), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(235), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "更新", new Guid("9c73ca2b-0412-4f8d-935f-047d6e264334"), null, null, "更新Api资源", 3, 2, "apiResource.update", new byte[] { 52, 57, 55, 51, 50, 65, 52, 54, 45, 54, 50, 70, 69, 45, 52, 48, 68, 50, 45, 65, 66, 54, 51, 45, 48, 68, 52, 52, 56, 53, 55, 65, 68, 53, 55, 67 } },
                    { new Guid("7f15a965-387d-43ab-951e-d23b07bd1675"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(186), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(187), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "更新", new Guid("1fc74685-c1d4-4ba9-8b81-04cf4b5ae8d0"), null, null, "更新操作资源", 3, 2, "operation.update", new byte[] { 65, 53, 50, 53, 65, 49, 67, 51, 45, 69, 57, 57, 67, 45, 52, 55, 70, 51, 45, 56, 68, 57, 53, 45, 48, 49, 54, 51, 57, 68, 70, 51, 67, 52, 53, 67 } },
                    { new Guid("8a22a16a-10d6-4886-a8f9-0de2dff88a9a"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(258), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(259), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("9c73ca2b-0412-4f8d-935f-047d6e264334"), null, null, "删除Api资源", 6, 2, "apiResource.delete", new byte[] { 70, 57, 68, 65, 53, 66, 51, 51, 45, 57, 68, 65, 66, 45, 52, 54, 52, 69, 45, 56, 65, 49, 51, 45, 48, 68, 69, 52, 56, 56, 51, 66, 56, 69, 65, 54 } },
                    { new Guid("93742f2a-a27b-44f9-8e43-0dfae065cefa"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(265), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(265), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("b3434421-1ac6-4f4b-8bed-04acccd8c91c"), null, null, "查看身份资源", 1, 2, "identityResource.view", new byte[] { 56, 48, 50, 65, 66, 68, 51, 49, 45, 69, 66, 68, 53, 45, 52, 68, 65, 70, 45, 66, 66, 48, 56, 45, 48, 69, 50, 52, 48, 67, 56, 56, 57, 53, 55, 68 } },
                    { new Guid("95031849-2da1-464b-948e-8218415e641f"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(181), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(181), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("1fc74685-c1d4-4ba9-8b81-04cf4b5ae8d0"), null, null, "创建操作资源", 2, 2, "operation.create", new byte[] { 70, 50, 65, 57, 52, 66, 53, 65, 45, 69, 52, 54, 65, 45, 52, 66, 52, 50, 45, 66, 70, 54, 69, 45, 48, 49, 53, 51, 69, 69, 65, 57, 68, 69, 50, 56 } },
                    { new Guid("972b89f8-2c28-45cd-ad4d-0d7e22bcaa13"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(252), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(253), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "禁用", new Guid("9c73ca2b-0412-4f8d-935f-047d6e264334"), null, null, "禁用Api资源", 5, 2, "apiResource.disable", new byte[] { 48, 55, 52, 50, 57, 53, 57, 56, 45, 56, 50, 68, 68, 45, 52, 56, 53, 67, 45, 65, 57, 69, 49, 45, 48, 68, 65, 70, 54, 52, 50, 70, 49, 67, 69, 53 } },
                    { new Guid("9d68775e-1ebf-48e6-b668-0ef97f054068"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(281), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(282), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("b3434421-1ac6-4f4b-8bed-04acccd8c91c"), null, null, "删除身份资源", 4, 2, "identityResource.delete", new byte[] { 55, 54, 52, 65, 48, 68, 49, 68, 45, 55, 69, 51, 70, 45, 52, 57, 67, 48, 45, 57, 70, 55, 55, 45, 48, 70, 49, 57, 66, 53, 68, 52, 68, 68, 66, 65 } },
                    { new Guid("9d9ba908-80c7-48ad-8ee9-f43772f7c738"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(192), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(193), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "删除", new Guid("1fc74685-c1d4-4ba9-8b81-04cf4b5ae8d0"), null, null, "删除操作资源", 4, 2, "operation.delete", new byte[] { 67, 70, 70, 67, 69, 55, 55, 53, 45, 48, 67, 55, 56, 45, 52, 48, 55, 56, 45, 56, 57, 50, 67, 45, 48, 49, 54, 52, 52, 52, 67, 48, 70, 49, 54, 51 } },
                    { new Guid("a67d5d7e-8cef-440d-8e7d-e7d2f4e3c321"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(124), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(125), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), null, null, "查看模块资源", 1, 2, "module.view", new byte[] { 48, 68, 52, 52, 57, 56, 66, 57, 45, 56, 52, 50, 57, 45, 52, 52, 54, 55, 45, 66, 49, 65, 66, 45, 50, 55, 50, 67, 55, 65, 57, 54, 51, 56, 68, 54 } },
                    { new Guid("c389755d-2f53-4f79-ad4e-01841ca12bad"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(223), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[],\"IsBase\":true}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(224), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "查看", new Guid("9c73ca2b-0412-4f8d-935f-047d6e264334"), null, null, "查看Api资源", 1, 2, "apiResource.view", new byte[] { 69, 68, 65, 50, 67, 52, 67, 56, 45, 55, 67, 48, 49, 45, 52, 57, 57, 68, 45, 66, 49, 55, 55, 45, 48, 67, 66, 69, 68, 51, 66, 48, 53, 56, 54, 50 } },
                    { new Guid("c84bde6f-ce06-400c-91d9-38b4308914c8"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(143), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(143), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "禁用", new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), null, null, "禁用模块资源", 1, 2, "module.disable", new byte[] { 48, 49, 50, 67, 52, 55, 69, 52, 45, 52, 54, 49, 50, 45, 52, 66, 54, 68, 45, 56, 65, 50, 68, 45, 48, 69, 54, 67, 66, 51, 55, 66, 66, 70, 49, 70 } },
                    { new Guid("ccb020f6-c756-4183-a180-0e8ed9ec5170"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(276), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(276), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "更新", new Guid("b3434421-1ac6-4f4b-8bed-04acccd8c91c"), null, null, "更新身份资源", 3, 2, "identityResource.update", new byte[] { 51, 55, 67, 51, 50, 48, 57, 53, 45, 54, 66, 48, 69, 45, 52, 52, 52, 48, 45, 56, 68, 48, 52, 45, 48, 69, 65, 57, 51, 67, 68, 49, 70, 65, 54, 70 } },
                    { new Guid("d2a61ff2-b713-41a8-a5ee-f9349b49aa21"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(150), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(151), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "更新", new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), null, null, "更新模块资源", 1, 2, "module.update", new byte[] { 50, 66, 67, 65, 69, 67, 67, 49, 45, 52, 68, 54, 53, 45, 52, 66, 68, 55, 45, 56, 69, 66, 52, 45, 49, 52, 67, 55, 49, 69, 48, 51, 53, 67, 70, 65 } },
                    { new Guid("da5ebca9-f2e1-4cf8-93a6-0e48dcb0c461"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(270), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(271), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "创建", new Guid("b3434421-1ac6-4f4b-8bed-04acccd8c91c"), null, null, "创建身份资源", 2, 2, "identityResource.create", new byte[] { 68, 51, 53, 49, 54, 52, 65, 49, 45, 54, 55, 51, 51, 45, 52, 49, 55, 55, 45, 65, 69, 70, 68, 45, 48, 69, 52, 70, 54, 65, 51, 53, 48, 49, 49, 56 } },
                    { new Guid("f29522ba-ef0b-488f-b4f3-49a8dfe7042e"), new Guid("e9138a35-a4ff-460e-ac55-b743d55b9691"), new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(162), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), true, "{\"Claims\":[]}", false, new DateTime(2024, 4, 15, 16, 26, 18, 648, DateTimeKind.Utc).AddTicks(162), new Guid("55ba53a6-e482-4d9b-8d91-3fba6610b896"), 0, "资源设置", new Guid("a6769fb3-1e3b-4fc4-b04c-f0338495dbed"), null, null, "模块资源设置", 1, 2, "module.settings", new byte[] { 48, 52, 69, 49, 51, 70, 56, 65, 45, 51, 53, 52, 54, 45, 52, 56, 68, 57, 45, 56, 68, 70, 53, 45, 50, 68, 55, 51, 65, 52, 57, 67, 67, 53, 56, 69 } }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationId",
                table: "Application",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Claim_ClaimId",
                table: "Claim",
                column: "ClaimId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommonOperation_OperationId",
                table: "CommonOperation",
                column: "OperationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionId",
                table: "Permission",
                column: "PermissionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_ResourceId",
                table: "Permission",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ApplicationId",
                table: "Resource",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ParentId",
                table: "Resource",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourceId",
                table: "Resource",
                column: "ResourceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleId",
                table: "Role",
                column: "RoleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId",
                table: "User",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "CommonOperation");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
