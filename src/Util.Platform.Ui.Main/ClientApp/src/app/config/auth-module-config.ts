import { OAuthModuleConfig } from 'angular-oauth2-oidc';
import { bootstrapConfig } from './bootstrap-config';

/**
 *  ⁄»®ƒ£øÈ≈‰÷√
 */
export const authModuleConfig: OAuthModuleConfig = {
    resourceServer: {
        allowedUrls: [bootstrapConfig.apiEndpointUrl],
        sendAccessToken: true
    }
};
