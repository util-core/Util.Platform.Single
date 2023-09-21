import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { TableQueryComponentBase } from 'util-angular';
import { ResourceQuery } from '../resource/model/resource-query';
import { IdentityResourceViewModel } from './model/identity-resource-view-model';
import { IdentityResourceEditComponent } from './identity-resource-edit.component';
import { IdentityResourceDetailComponent } from './identity-resource-detail.component';

/**
 * 身份资源列表页
 */
@Component({
    selector: 'identity-resource-list',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/identityResource'
})
export class IdentityResourceListComponent extends TableQueryComponentBase<IdentityResourceViewModel, ResourceQuery>  {
    /**
     * 初始化身份资源列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 获取创建弹出框组件
     */
    getCreateComponent() {
        return IdentityResourceEditComponent;
    }

    /**
     * 获取详情弹出框组件
     */
    getDetailComponent() {
        return IdentityResourceDetailComponent;
    }
}