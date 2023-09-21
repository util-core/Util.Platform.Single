namespace Util.Platform.Tests.Share.Fakes.Identity;

/// <summary>
/// 应用程序模拟数据服务
/// </summary>
public static class ApplicationFakeService {
    /// <summary>
    /// 获取应用程序
    /// </summary>
    public static Application GetApplication() {
        return GetApplications( 1 ).First();
    }

    /// <summary>
    /// 获取应用程序列表
    /// </summary>
    /// <param name="count">行数</param>
    public static List<Application> GetApplications( int count ) {
        return new AutoFaker<Application>()
            .RuleFor( t => t.Code, t => t.Random.String2( 1, 60 ) )
            .RuleFor( t => t.Name, t => t.Random.String2( 1, 200 ) )
            .RuleFor( t => t.Remark, t => t.Random.String2( 1, 500 ) )
            .RuleFor( t => t.IsDeleted, false )
            .Generate( count );
    }
}