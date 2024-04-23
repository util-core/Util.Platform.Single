namespace Util.Platform.Tests.Share.Fakes.Identity;

/// <summary>
/// 模块参数模拟数据服务
/// </summary>
public static class ModuleDtoFakeService {
    /// <summary>
    /// 获取资源
    /// </summary>
    public static ModuleDto GetModuleDto() {
        return GetModuleDtos( 1 ).First();
    }

    /// <summary>
    /// 获取资源列表
    /// </summary>
    /// <param name="count">行数</param>
    public static List<ModuleDto> GetModuleDtos( int count ) {
        return new AutoFaker<ModuleDto>()
            .Ignore( t => t.Id )
            .Ignore( t => t.ParentId )
            .Ignore( t => t.Path )
            .Ignore( t => t.Level )
            .Ignore( t => t.Children )
            .RuleFor( t => t.Uri, t => t.Random.String2( 1, 300 ) )
            .RuleFor( t => t.Name, t => t.Random.String2( 1, 200 ) )
            .RuleFor( t => t.Remark, t => t.Random.String2( 1, 500 ) )
            .Generate( count );
    }
}