import { ModuleWithProviders, NgModule, Optional, SkipSelf } from '@angular/core';
import { DelonACLModule } from '@delon/acl';
import { AlainThemeModule } from '@delon/theme';
import { AlainConfig, ALAIN_CONFIG } from '@delon/util/config';
import { environment } from '@env/environment';
import { NzConfig, NZ_CONFIG } from 'ng-zorro-antd/core/config';
import { RouteReuseStrategy } from '@angular/router';
import { ReuseTabService, ReuseTabStrategy } from '@delon/abc/reuse-tab';

const alainConfig: AlainConfig = {
    pageHeader: { homeI18n: 'home' }
};
const alainModules: any[] = [AlainThemeModule.forRoot(), DelonACLModule];
const alainProvides = [{ provide: ALAIN_CONFIG, useValue: alainConfig }, ReuseTabService];
alainProvides.push({ provide: RouteReuseStrategy, useClass: ReuseTabStrategy, deps: [ReuseTabService] } as any);
const ngZorroConfig: NzConfig = {};
const zorroProvides = [{ provide: NZ_CONFIG, useValue: ngZorroConfig }];

/**
 * 全局配置模块
 */
@NgModule({
    imports: [...alainModules, ...(environment.modules || [])]
})
export class GlobalConfigModule {
    constructor(@Optional() @SkipSelf() parent: GlobalConfigModule) {
        if (parent) {
            throw new Error('全局配置模块已加载！');
        }
    }

    static forRoot(): ModuleWithProviders<GlobalConfigModule> {
        return {
            ngModule: GlobalConfigModule,
            providers: [...alainProvides, ...zorroProvides]
        };
    }
}
