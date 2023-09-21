import { Component, Injector,OnInit } from '@angular/core';
import { environment } from "@env/environment";
import { TableQueryComponentBase } from 'util-angular';
import { UserQuery } from '../user/model/user-query';
import { UserViewModel } from '../user/model/user-view-model';

/**
 * 选择用户列表页
 */
@Component({
    selector: 'select-users',
    templateUrl: environment.production ? './html/select-users.component.html' : '/view/routes/identity/role/selectUsers'
} )
export class SelectUsersComponent extends TableQueryComponentBase<UserViewModel, UserQuery> implements OnInit {
    /**
     * 初始化选择用户列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 初始化
     */
    ngOnInit() {
        this.queryParam.exceptRoleId = this.getRoleId();
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
            result.exceptRoleId = this.getRoleId();
        return result;
    }
}