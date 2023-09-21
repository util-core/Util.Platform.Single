import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from 'util-angular';
import { IdentityResourceViewModel } from './model/identity-resource-view-model';

/**
 * 身份资源详情页
 */
@Component({
    selector: 'identity-resource-detail',
    templateUrl: environment.production ? './html/detail.component.html' : '/view/routes/identity/identityResource/detail'
})
export class IdentityResourceDetailComponent extends EditComponentBase<IdentityResourceViewModel> {
    /**
     * 初始化身份资源详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "identityResource";
    }
}