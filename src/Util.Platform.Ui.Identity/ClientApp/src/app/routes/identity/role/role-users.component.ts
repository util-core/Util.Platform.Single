import { Component, Injector, OnInit } from '@angular/core';
import { environment } from "@env/environment";
import { TableQueryComponentBase } from 'util-angular';
import { UserQuery } from '../user/model/user-query';
import { UserViewModel } from '../user/model/user-view-model';
import { SelectUsersComponent } from './select-users.component';

/**
 * 角色用户列表页
 */
@Component( {
    selector: 'role-users',
    templateUrl: environment.production ? './html/role-users.component.html' : '/view/routes/identity/role/roleUsers'
} )
export class RoleUsersComponent extends TableQueryComponentBase<UserViewModel, UserQuery> implements OnInit {
    /**
     * 初始化角色用户列表页
     * @param injector 注入器
     */
    constructor( injector: Injector ) {
        super( injector );
    }

    /**
     * 初始化
     */
    ngOnInit() {
        this.queryParam.roleId = this.getRoleId();
    }

    /**
     * 获取角色标识
     */
    getRoleId() {
        return this.data.id;
    }

    /**
     * 创建查询参数
     */
    createQuery() {
        let result = new UserQuery();
        if ( this.data )
            result.roleId = this.getRoleId();
        return result;
    }

    /**
     * 打开选择用户列表弹出框
     */
    openSelectDialog() {
        this.util.dialog.open( {
            component: SelectUsersComponent,
            data: { data: this.data },
            width: "80%",
            centered:true,
            disableClose: true,
            onOk: instance => {
                let userIds = instance.getCheckedIds();
                this.select( userIds );
                return false;
            },
            onClose: result => {
                if ( result )
                    this.query();
            }
        } );
    }

    /**
     * 选中用户
     */
    select( userIds ) {
        if ( !userIds ) {
            this.util.message.warn( "identity.role.selectUserMessage" );
            return;
        }
        this.util.form.submit( {
            url: "role/addUsersToRole",
            data: { roleId: this.getRoleId(), userIds: userIds },
            confirm: "identity.role.addUsersToRoleConfirm",
            closeDialog: true
        } );
    }

    /**
     * 从角色移除用户
     */
    removeUsersFromRole() {
        let userIds = this.getCheckedIds();
        if ( !userIds ) {
            this.util.message.warn( "identity.role.removeUsersFromRoleMessage" );
            return;
        }
        this.util.form.submit( {
            url: "role/removeUsersFromRole",
            data: { roleId: this.getRoleId(), userIds: userIds },            
            confirm: "identity.role.removeUsersFromRoleConfirm",
            ok: () => {
                this.query();
            }
        } );
    }
}