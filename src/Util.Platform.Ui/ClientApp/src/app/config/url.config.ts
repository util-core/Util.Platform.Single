import { environment } from '@env/environment';

/**
 * Url配置
 */
export const urlConfig = {
    /**
     * 认证服务器地址
     */
    identityUrl: environment.identityUrl,
    /**
     * Api端点地址
     */
    apiEndpointUrl: environment.apiEndpointUrl,
    /**
     * 获取应用数据地址
     */
    appDataUrl: "/api/app/appData"
};