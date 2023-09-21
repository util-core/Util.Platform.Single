import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from 'util-angular';
import { IdentityResourceViewModel } from './model/identity-resource-view-model';

/**
 * 身份资源编辑页
 */
@Component({
    selector: 'identity-resource-edit',
    templateUrl: environment.production ? './html/edit.component.html' : '/view/routes/identity/identityResource/edit'
})
export class IdentityResourceEditComponent extends EditComponentBase<IdentityResourceViewModel> {
    /**
     * 初始化身份资源编辑页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 创建模型
     */
    createModel() {
        let result = new IdentityResourceViewModel();
        result.enabled = true;
        return result;
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "identityResource";
    }
}