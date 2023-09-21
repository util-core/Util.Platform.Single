import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { TableQueryComponentBase } from "util-angular";
import { UserQuery } from './model/user-query';
import { UserViewModel } from './model/user-view-model';
import { UserEditComponent } from './user-edit.component';
import { UserDetailComponent } from './user-detail.component';

/**
* 用户列表页
*/
@Component( {
    selector: 'user-list',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/user',
} )
export class UserListComponent extends TableQueryComponentBase<UserViewModel, UserQuery> {
    /**
     * 初始化用户列表页
     * @param injector 注入器
     */
    constructor( injector: Injector ) {
        super( injector );
    }

    /**
     * 获取创建弹出框组件
     */
    getCreateComponent() {
        return UserEditComponent;
    }

    /**
     * 获取详情弹出框组件
     */
    getDetailComponent() {
        return UserDetailComponent;
    }
}