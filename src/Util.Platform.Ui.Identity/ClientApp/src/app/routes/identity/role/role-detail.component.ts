import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { RoleViewModel } from './model/role-view-model';

/**
* 角色详情页
*/
@Component({
    selector: 'role-detail',
    templateUrl: environment.production ? './html/detail.component.html' : '/view/routes/identity/role/detail'
})
export class RoleDetailComponent extends EditComponentBase<RoleViewModel> {
    /**
     * 初始化角色详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "role";
    }
}