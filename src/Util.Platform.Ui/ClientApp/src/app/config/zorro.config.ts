import { EnvironmentProviders } from '@angular/core';
import { NzConfig, provideNzConfig } from 'ng-zorro-antd/core/config';

//ng-zorro配置
const config: NzConfig = {};

/**
 * ng-zorro配置提供器
 */
export const provideNgZorro = (): EnvironmentProviders => {
    return provideNzConfig(config);
}