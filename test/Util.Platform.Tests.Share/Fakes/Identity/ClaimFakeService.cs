namespace Util.Platform.Tests.Share.Fakes.Identity;

/// <summary>
/// 声明模拟数据服务
/// </summary>
public static class ClaimFakeService {
    /// <summary>
    /// 获取声明
    /// </summary>
    public static Claim GetClaim() {
        return GetClaims( 1 ).First();
    }

    /// <summary>
    /// 获取声明列表
    /// </summary>
    /// <param name="count">行数</param>
    public static List<Claim> GetClaims( int count ) {
        return new AutoFaker<Claim>()
            .RuleFor( t => t.Name, t => t.Random.String2( 1, 200 ) )
            .RuleFor( t => t.Remark, t => t.Random.String2( 1, 500 ) )
            .RuleFor( t => t.IsDeleted, false )
            .Generate( count );
    }
}