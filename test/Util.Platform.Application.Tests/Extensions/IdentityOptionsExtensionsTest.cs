namespace Util.Platform.Application.Tests.Extensions; 

/// <summary>
/// Identity≈‰÷√¿©’π≤‚ ‘
/// </summary>
public class IdentityOptionsExtensionsTest {
    /// <summary>
    /// »®œﬁ≈‰÷√
    /// </summary>
    private readonly PermissionOptions _permissionOptions;
    /// <summary>
    /// ±Í ∂≈‰÷√
    /// </summary>
    private readonly IdentityOptions _identityOptions;

    /// <summary>
    /// ≤‚ ‘≥ı ºªØ
    /// </summary>
    public IdentityOptionsExtensionsTest() {
        _permissionOptions = new PermissionOptions();
        _identityOptions = new IdentityOptions();
    }

    /// <summary>
    /// ≤‚ ‘º”‘ÿ
    /// </summary>
    [Fact]
    public void TestLoad() {
        var emailClaimType = "EmailClaimType_1";
        var allowedUserNameCharacters = "abc";
        _permissionOptions.ClaimsIdentity.EmailClaimType = emailClaimType;
        _permissionOptions.User.AllowedUserNameCharacters = allowedUserNameCharacters;
        _identityOptions.Load( _permissionOptions );
        Assert.Equal( emailClaimType, _identityOptions.ClaimsIdentity.EmailClaimType );
        Assert.Equal( allowedUserNameCharacters, _identityOptions.User.AllowedUserNameCharacters );
    }
}