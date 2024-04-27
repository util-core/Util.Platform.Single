import { Component, ChangeDetectionStrategy } from '@angular/core';
import { EditComponentBase } from "util-angular";
import { RoleViewModel } from './model/role-view-model';

/**
* 角色详情页
*/
@Component({
    selector: 'role-detail',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/role-detail.component.html'
})
export class RoleDetailComponent extends EditComponentBase<RoleViewModel> {
    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "role";
    }
}