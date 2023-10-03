import { AppConfig } from 'util-angular';
import { bootstrapConfig } from './bootstrap-config';

/**
 * 应用配置
 */
export const appConfig: AppConfig = {
    /**
     * Api端点基地址
     */
    apiEndpoint: bootstrapConfig.apiEndpointUrl
}