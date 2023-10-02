namespace Util.Platform.Api.Services; 

/// <summary>
/// 跨域策略服务
/// </summary>
public class CorsPolicyService : CorsPolicyServiceBase<IApplicationService,ApplicationDto,ApplicationQuery> {
    /// <summary>
    /// 初始化跨域策略服务
    /// </summary>
    /// <param name="applicationService">应用程序服务</param>
    public CorsPolicyService( IApplicationService applicationService ) : base( applicationService ) {
    }
}