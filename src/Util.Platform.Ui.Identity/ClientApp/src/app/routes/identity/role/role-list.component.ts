import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { TableQueryComponentBase } from "util-angular";
import { RoleQuery } from './model/role-query';
import { RoleViewModel } from './model/role-view-model';
import { RoleEditComponent } from './role-edit.component';
import { RoleDetailComponent } from './role-detail.component';
import { RoleUsersComponent } from './role-users.component';
import { PermissionComponent } from '../permission/index.component';

/**
* 角色列表页
*/
@Component({
    selector: 'role-list',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/role',
})
export class RoleListComponent extends TableQueryComponentBase<RoleViewModel, RoleQuery> {
    /**
    * 初始化角色列表页
    * @param injector 注入器
    */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
    * 获取创建弹出框组件
    */
    getCreateComponent() {
        return RoleEditComponent;
    }

    /**
    * 获取详情弹出框组件
    */
    getDetailComponent() {
        return RoleDetailComponent;
    }

    /**
     * 打开角色用户设置弹出框
     */
    openRoleUsersDialog(role) {       
        this.util.dialog.open({
            component: RoleUsersComponent,
            data: { data: role },
            showOk: false,
            disableClose: true,
            width: "80%",
            centered:true
        });
    }

    /**
     * 打开权限设置弹出框
     */
    openPermissionDialog( role ) {
        this.util.dialog.open( {
            component: PermissionComponent,
            data: { role: role },
            disableClose: true,
            centered: true,
            width: "80%",
            onOk: instance => {
                instance.save();
                return false;
            },
        } );
    }
}