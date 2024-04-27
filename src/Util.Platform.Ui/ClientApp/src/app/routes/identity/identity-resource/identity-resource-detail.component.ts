import { Component, ChangeDetectionStrategy } from '@angular/core';
import { EditComponentBase } from 'util-angular';
import { IdentityResourceViewModel } from './model/identity-resource-view-model';

/**
 * 身份资源详情页
 */
@Component({
    selector: 'identity-resource-detail',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/identity-resource-detail.component.html'
})
export class IdentityResourceDetailComponent extends EditComponentBase<IdentityResourceViewModel> {
    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "identityResource";
    }
}