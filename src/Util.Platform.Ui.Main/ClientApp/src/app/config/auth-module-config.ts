import { OAuthModuleConfig } from 'angular-oauth2-oidc';
import { bootstrapConfig } from './bootstrap-config';

/**
 * 授权模块配置
 */
export const authModuleConfig: OAuthModuleConfig = {
    resourceServer: {
        allowedUrls: [bootstrapConfig.apiEndpointUrl],
        sendAccessToken: true
    }
};
