import { Injectable } from '@angular/core';
import { Util, AppConfig } from 'util-angular';

/**
 * 租户初始化服务 - 将域名映射成租户标识
 */
@Injectable()
export class TenantInitService {
    /**
     * 操作入口
     */
    private util: Util;

    /**
     * 初始化租户服务
     * @param appConfig 应用配置
     */
    constructor(appConfig: AppConfig) {
        this.util = new Util(null, appConfig);
    }

    /**
     * 初始化
     */
    async initial(): Promise<void> {
        let config = this.util.getAppConfig();
        if (!config)
            return;
        if (!config.tenant)
            return;
        if (!config.tenant.isEnabled)
            return;
        let tenant = this.util.tenant.getTenant();
        if (tenant)
            return;
        let url = "/api/tenant/resolve";
        await this.util.webapi.get<string>(url).param("host", location.host).handleAsync({
            ok: (result) => this.util.tenant.setTenant(result)
        });
    }
}
