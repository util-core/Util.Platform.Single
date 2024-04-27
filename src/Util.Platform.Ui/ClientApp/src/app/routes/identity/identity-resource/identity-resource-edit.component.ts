import { Component, ChangeDetectionStrategy } from '@angular/core';
import { EditComponentBase } from 'util-angular';
import { IdentityResourceViewModel } from './model/identity-resource-view-model';

/**
 * 身份资源编辑页
 */
@Component({
    selector: 'identity-resource-edit',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/identity-resource-edit.component.html'
})
export class IdentityResourceEditComponent extends EditComponentBase<IdentityResourceViewModel> {
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