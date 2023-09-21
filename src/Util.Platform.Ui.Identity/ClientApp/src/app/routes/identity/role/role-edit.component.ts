import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { RoleViewModel } from './model/role-view-model';

/**
 * 角色编辑页
 */
@Component( {
    selector: 'role-edit',
    templateUrl: environment.production ? './html/edit.component.html' : '/view/routes/identity/role/edit'
} )
export class RoleEditComponent extends EditComponentBase<RoleViewModel> {
    /**
     * 初始化角色编辑页
     * @param injector 注入器
     */
    constructor( injector: Injector ) {
        super(injector);
    }

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