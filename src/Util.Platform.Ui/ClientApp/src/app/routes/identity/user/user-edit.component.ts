import { Component, ChangeDetectionStrategy } from '@angular/core';
import { EditComponentBase } from "util-angular";
import { UserViewModel } from './model/user-view-model';

/**
 * 用户编辑页
 */
@Component( {
    selector: 'user-edit',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/user-edit.component.html'
} )
export class UserEditComponent extends EditComponentBase<UserViewModel> {
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