namespace Util.Platform.Api.Services; 

/// <summary>
/// 客户端存储
/// </summary>
public class ClientStore : ClientStoreBase<IApplicationService,ApplicationDto,ApplicationQuery> {
    /// <summary>
    /// 初始化客户端存储
    /// </summary>
    /// <param name="service">应用程序服务</param>
    public ClientStore( IApplicationService service ) : base( service ) {
    }
}