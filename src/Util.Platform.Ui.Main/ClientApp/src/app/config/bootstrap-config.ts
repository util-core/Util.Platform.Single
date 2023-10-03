import { NzSafeAny } from 'ng-zorro-antd/core/types';

/**
 * window
 */
const win = window as NzSafeAny;

/**
 * 启动配置
 */
export const bootstrapConfig = {
    /**
     * 微前端配置Url
     */
    manifestUrl: win.bootstrapConfig.manifestUrl,
    /**
     * 认证服务器地址
     */
    identityUrl: win.bootstrapConfig.identityUrl,
    /**
     * Api端点基地址
     */
    apiEndpointUrl: win.bootstrapConfig.apiEndpointUrl
};
