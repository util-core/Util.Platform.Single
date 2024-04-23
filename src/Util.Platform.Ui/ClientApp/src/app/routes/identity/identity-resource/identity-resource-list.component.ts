import { Component, ChangeDetectionStrategy, Injector } from '@angular/core';
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
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/identity-resource-list.component.html'
})
export class IdentityResourceListComponent extends TableQueryComponentBase<IdentityResourceViewModel, ResourceQuery>  {    
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

    /**
     * 获取创建标题
     */
    getCreateTitle() {
        return 'identity.identityResource.create';
    }

    /**
     * 获取更新标题
     */
    getEditTitle() {
        return 'identity.identityResource.update';
    }

    /**
     * 获取详情标题
     */
    getDetailTitle() {
        return 'identity.identityResource.detail';
    }
}