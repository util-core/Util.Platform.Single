import { AuthConfig } from 'angular-oauth2-oidc';
import { bootstrapConfig } from './bootstrap-config';

/**
* 授权配置
*/
export const authConfig: AuthConfig = {
    /** 
     * 认证服务器地址
     */
    issuer: bootstrapConfig.identityUrl,
    /**
     * 客户端标识
     */
    clientId: 'admin-ui',
    /**
     * 使用授权码模式
     */
    responseType: 'code',
    /**
     * 认证成功返回的地址
     */
    redirectUri: `${location.origin}/`,
    /**
     * 权限范围
     */
    scope: 'openid profile offline_access',
    /**
     * 是否显示调试信息
     */
    showDebugInformation: false
};
