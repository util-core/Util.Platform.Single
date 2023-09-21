namespace Util.Platform.Api.Controllers.Tools;

/// <summary>
/// 头像控制器
/// </summary>
[AllowAnonymous]
public class AvatarController : WebApiControllerBase {
    /// <summary>
    /// 初始化头像控制器
    /// </summary>
    /// <param name="service">头像服务</param>
    public AvatarController( IAvatarService service ) {
        AvatarService = service ?? throw new ArgumentNullException( nameof( service ) );
    }

    /// <summary>
    /// 头像服务
    /// </summary>
    protected IAvatarService AvatarService { get; }

    /// <summary>
    /// 获取头像
    /// </summary>
    /// <param name="dto">头像参数</param>
    [HttpGet]
    public async Task<IActionResult> GetAvatarAsync( [FromQuery] AvatarDto dto ) {
        var result = await AvatarService.GetAvatarAsync( dto );
        return new FileContentResult( result, "image/png" );
    }
}