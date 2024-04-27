import { Component, ChangeDetectionStrategy } from '@angular/core';
import { EditComponentBase } from "util-angular";
import { RoleViewModel } from './model/role-view-model';

/**
 * 角色编辑页
 */
@Component( {
    selector: 'role-edit',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/role-edit.component.html'
} )
export class RoleEditComponent extends EditComponentBase<RoleViewModel> {
    /**
     * 创建模型
     */
    protected createModel() {
        let result = new RoleViewModel;
        result.enabled = true;
        return result;
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "role";
    }
}