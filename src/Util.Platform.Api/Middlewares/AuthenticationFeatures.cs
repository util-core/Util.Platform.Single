namespace Util.Platform.Api.Middlewares;

/// <summary>
/// 认证功能
/// </summary>
public class AuthenticationFeatures : IAuthenticateResultFeature, IHttpAuthenticationFeature {
    private ClaimsPrincipal _user;
    private AuthenticateResult _result;

    public AuthenticationFeatures( AuthenticateResult result ) {
        AuthenticateResult = result;
    }

    public AuthenticateResult AuthenticateResult {
        get => _result;
        set {
            _result = value;
            _user = _result?.Principal;
        }
    }

    public ClaimsPrincipal User {
        get => _user;
        set {
            _user = value;
            _result = null;
        }
    }
}