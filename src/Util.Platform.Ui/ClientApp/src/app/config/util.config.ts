import { Provider } from '@angular/core';
import { AppConfig } from 'util-angular';
import { urlConfig } from './url.config';

/**
 * Util配置提供器
 */
export const provideUtil = (): Provider[] => {
    return [{ provide: AppConfig, useValue: config }];
}

/**
* Util应用配置
*/
const config: AppConfig = {
    /**
    * Api端点地址
    */
    apiEndpoint: urlConfig.apiEndpointUrl,
    /**
     * 分页大小
     */
    pageSize: 20,
    /**
     * 弹出层配置
     */
    dialog: {
        addWrapClass: true
    }
}