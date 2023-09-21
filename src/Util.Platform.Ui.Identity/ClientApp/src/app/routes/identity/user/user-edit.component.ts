import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { UserViewModel } from './model/user-view-model';

/**
 * 用户编辑页
 */
@Component( {
    selector: 'user-edit',
    templateUrl: environment.production ? './html/edit.component.html' : '/view/routes/identity/user/edit'
} )
export class UserEditComponent extends EditComponentBase<UserViewModel> {
    /**
     * 初始化用户编辑页
     * @param injector 注入器
     */
    constructor( injector: Injector ) {
        super( injector );
    }

    /**
     * 创建模型
     */
    protected createModel() {
        let result = new UserViewModel;
        return result;
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "user";
    }
}