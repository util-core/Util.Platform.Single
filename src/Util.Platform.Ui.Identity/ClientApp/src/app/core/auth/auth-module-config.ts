import { OAuthModuleConfig } from 'angular-oauth2-oidc';
import { urlConfig } from '../../config/url-config';

/**
 * 授权模块配置
 */
export const authModuleConfig: OAuthModuleConfig = {
    resourceServer: {
        allowedUrls: [urlConfig.apiEndpointUrl],
        sendAccessToken: true
    }
};
