import { NzSafeAny } from 'ng-zorro-antd/core/types';

/**
 * window
 */
const win = window as NzSafeAny;

/**
 * 生产环境配置
 */
export const environment = {
    /**
     * 是否生产环境
     */
    production: true,
    /**
     * 是否使用带 # 的 url
     */
    useHash: false,
    /**
     * 认证服务器地址
     */
    identityUrl: win.bootstrapConfig.identityUrl,
    /**
     * Api端点地址
     */
    apiEndpointUrl: win.bootstrapConfig.apiEndpointUrl
};