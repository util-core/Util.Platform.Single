namespace Util.Platform.Tests.Share.Fakes.Identity; 

/// <summary>
/// 角色模拟数据服务
/// </summary>
public static class RoleDtoFakeService {
    /// <summary>
    /// 获取角色
    /// </summary>
    public static RoleDto GetRoleDto() {
        return GetRoleDtos( 1 ).First();
    }

    /// <summary>
    /// 获取角色列表
    /// </summary>
    /// <param name="count">行数</param>
    public static List<RoleDto> GetRoleDtos( int count ) {
        return new AutoFaker<RoleDto>()
            .Ignore( t => t.Id )
            .Ignore( t => t.PinYin )
            .Ignore( t => t.Type )
            .RuleFor( t => t.Code, t => t.Random.String2( 1, 256 ) )
            .RuleFor( t => t.Name, t => t.Random.String2( 1, 256 ) )
            .RuleFor( t => t.Remark, t => t.Random.String2( 1, 500 ) )
            .Generate( count );
    }
}