namespace Util.Platform.Tests.Share.Fakes.Identity; 

/// <summary>
/// 声明模拟数据服务
/// </summary>
public static class ClaimDtoFakeService {
    /// <summary>
    /// 获取声明
    /// </summary>
    public static ClaimDto GetClaimDto() {
        return GetClaimDtos( 1 ).First();
    }

    /// <summary>
    /// 获取声明列表
    /// </summary>
    /// <param name="count">行数</param>
    public static List<ClaimDto> GetClaimDtos( int count ) {
        return new AutoFaker<ClaimDto>()
            .Ignore( t => t.Id )
            .RuleFor( t => t.Name, t => t.Random.String2( 1, 200 ) )
            .RuleFor( t => t.Remark, t => t.Random.String2( 1, 500 ) )
            .Generate( count );
    }
}