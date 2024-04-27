import { Component, ChangeDetectionStrategy } from '@angular/core';
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
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/user-list.component.html'
} )
export class UserListComponent extends TableQueryComponentBase<UserViewModel, UserQuery> {
    /**
     * 获取创建组件
     */
    getCreateComponent() {
        return UserEditComponent;
    }

    /**
     * 获取详情组件
     */
    getDetailComponent() {
        return UserDetailComponent;
    }

    /**
     * 获取创建标题
     */
    getCreateTitle() {
        return 'identity.user.create';
    }

    /**
     * 获取更新标题
     */
    getEditTitle() {
        return 'identity.user.update';
    }

    /**
     * 获取详情标题
     */
    getDetailTitle() {
        return 'identity.user.detail';
    }
}