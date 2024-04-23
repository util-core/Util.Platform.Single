import { Component, ChangeDetectionStrategy, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { TableQueryComponentBase } from "util-angular";
import { RoleQuery } from './model/role-query';
import { RoleViewModel } from './model/role-view-model';
import { RoleEditComponent } from './role-edit.component';
import { RoleDetailComponent } from './role-detail.component';
import { RoleUsersComponent } from './role-users.component';
import { PermissionComponent } from '../permission/permission.component';

/**
* 角色列表页
*/
@Component({
    selector: 'role-list',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/role-list.component.html'
})
export class RoleListComponent extends TableQueryComponentBase<RoleViewModel, RoleQuery> {
    /**
    * 获取创建组件
    */
    getCreateComponent() {
        return RoleEditComponent;
    }

    /**
    * 获取详情组件
    */
    getDetailComponent() {
        return RoleDetailComponent;
    }

    /**
     * 获取创建标题
     */
    getCreateTitle() {
        return 'identity.role.create';
    }

    /**
     * 获取更新标题
     */
    getEditTitle() {
        return 'identity.role.update';
    }

    /**
     * 获取详情标题
     */
    getDetailTitle() {
        return 'identity.role.detail';
    }

    /**
     * 打开角色用户设置窗口
     */
    openRoleUsersDialog(role) {
        this.util.dialog.open({
            component: RoleUsersComponent,
            title:"identity.role.roleUsers",
            data: { data: role },
            showOk: false,
            disableClose: true
        });
    }

    /**
     * 打开权限设置窗口
     */
    openPermissionDialog( role ) {
        this.util.dialog.open( {
            component: PermissionComponent,
            title: "identity.permission",
            data: { role: role },
            disableClose: true,
            addWrapClass:false,
            onOk: instance => {
                instance.save();
                return false;
            },
        } );
    }
}