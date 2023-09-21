import { NgModule, Optional, SkipSelf, ModuleWithProviders, APP_INITIALIZER } from '@angular/core';
import { AuthConfig, OAuthModuleConfig, OAuthModule } from 'angular-oauth2-oidc';
import { Util } from 'util-angular';
import { authConfig } from './auth/auth-config';
import { authModuleConfig } from './auth/auth-module-config';
import { TenantInitService } from './startup/tenant-init.service';
import { StartupService } from './startup/startup.service';

/**
 * 授权配置工厂
 */
export function AuthConfigFactory(): AuthConfig {
    let util = new Util();
    let appConfig = util.getAppConfig();
    if (!appConfig)
        return authConfig;
    if (!appConfig.tenant)
        return authConfig;
    if (!appConfig.tenant.isEnabled)
        return authConfig;
    let tenantId = util.tenant.getTenantId();
    let result = new AuthConfig();
    result.customQueryParams = { "x-tenant-id": tenantId };
    return util.helper.assign(result, authConfig);
}

/**
 * 租户初始化服务工厂
 * @param tenantInitService 租户初始化服务
 */
export function TenantInitServiceFactory(tenantInitService: TenantInitService): () => Promise<void> {
    return () => tenantInitService.initial();
}

/**
 * 启动服务工厂
 * @param startupService 启动服务
 */
export function StartupServiceFactory(startupService: StartupService): () => Promise<void> {
    return () => startupService.initial();
}

/**
* 核心模块
*/
@NgModule({
    imports: [OAuthModule.forRoot()]
})
export class CoreModule {
    /**
    * 初始化核心模块
    */
    constructor(@Optional() @SkipSelf() parent: CoreModule) {
        if (parent) {
            throw new Error('核心模块已加载！');
        }
    }

    /**
    * 核心模块
    */
    static forRoot(): ModuleWithProviders<CoreModule> {
        return {
            ngModule: CoreModule,
            providers: [
                TenantInitService,
                StartupService,
                { provide: AuthConfig, useFactory: AuthConfigFactory },
                { provide: OAuthModuleConfig, useValue: authModuleConfig },
                { provide: APP_INITIALIZER, useFactory: TenantInitServiceFactory, deps: [TenantInitService], multi: true },
                { provide: APP_INITIALIZER, useFactory: StartupServiceFactory, deps: [StartupService], multi: true }
            ]
        };
    }
}