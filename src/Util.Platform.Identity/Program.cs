using Util.Platform.Identity;

//创建Web应用程序生成器
var builder = WebApplication.CreateBuilder( args );

//配置控制器
builder.AddControllers();

//Util基础功能配置
builder.AddUtil();

//配置工作单元
builder.AddIdentityUnitOfWork();

//配置身份标识服务
builder.AddIdentity();

//配置身份验证服务器
builder.AddIdentityServer();

//配置认证
builder.Services.AddAuthentication();

//配置Cors
builder.AddCors();

//配置转发头部
builder.AddForwardedHeaders();

//配置Http日志
builder.AddHttpLogging();

//创建Web应用程序
var app = builder.Build();

//===== 配置请求管道 =====//

//配置Http日志记录
app.UseHttpLogging();

//配置异常页
app.UseCustomExceptionPage();

//配置基路径
app.UsePathBase();

//配置转发头部
app.UseForwardedHeaders();

//配置Cors
app.UseCors( "cors" );

//配置静态文件
app.UseStaticFiles();

//配置本地化
app.UseRequestLocalization();

//配置Cookie策略
app.UseCookiePolicy();

//配置路由
app.UseRouting();

//配置身份服务器
app.UseCustomIdentityServer();

//配置认证
app.UseAuthentication();

//配置租户
app.UseTenant();

//配置授权
app.UseAuthorization();

//配置控制器
app.MapDefaultControllerRoute();

try {
    //启动应用
    app.Logger.LogInformation( "准备启动应用 ..." );
    await app.RunAsync();
    return 0;
}
catch ( Exception ex ) {
    app.Logger.LogCritical( ex, "应用启动失败 ..." );
    return 1;
}
finally {
    Serilog.Log.CloseAndFlush();
}