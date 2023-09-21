namespace Util.Platform.Tests.Share.Fakes.Identity; 

/// <summary>
/// 应用程序模拟数据服务
/// </summary>
public static class ApplicationDtoFakeService {
    /// <summary>
    /// 获取应用程序
    /// </summary>
    public static ApplicationDto GetApplicationDto() {
        return GetApplicationDtos( 1 ).First();
    }

    /// <summary>
    /// 获取应用程序列表
    /// </summary>
    /// <param name="count">行数</param>
    public static List<ApplicationDto> GetApplicationDtos( int count ) {
        return new AutoFaker<ApplicationDto>()
            .Ignore( t => t.Id )
            .RuleFor( t => t.Code, t => t.Random.String2( 1, 60 ) )
            .RuleFor( t => t.Name, t => t.Random.String2( 1, 200 ) )
            .RuleFor( t => t.Remark, t => t.Random.String2( 1, 500 ) )
            .Generate( count );
    }
}