import { EnvironmentProviders } from '@angular/core';
import { NzConfig, provideNzConfig } from 'ng-zorro-antd/core/config';

//ng-zorro配置
const config: NzConfig = {
    descriptions: {
        nzColumn: { xs: 1, sm: 1, md: 1, lg: 1, xl: 2, xxl: 2 }
    }
};

/**
 * ng-zorro配置提供器
 */
export const provideNgZorro = (): EnvironmentProviders => {
    return provideNzConfig(config);
}