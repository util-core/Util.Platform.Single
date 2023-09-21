namespace Util.Platform.Identity.Services; 

/// <summary>
/// 密码验证器
/// </summary>
public class ResourceOwnerPasswordValidator : ResourceOwnerPasswordValidatorBase<ISystemService,LoginRequest> {
    /// <summary>
    /// 初始化密码验证器
    /// </summary>
    /// <param name="service">系统服务</param>
    public ResourceOwnerPasswordValidator( ISystemService service ) : base( service ) {
    }
}