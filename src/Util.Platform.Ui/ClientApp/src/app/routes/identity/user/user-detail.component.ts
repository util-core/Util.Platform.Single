import { Component, ChangeDetectionStrategy, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { UserViewModel } from './model/user-view-model';

/**
* 用户详情页
*/
@Component({
    selector: 'user-detail',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/user-detail.component.html'
})
export class UserDetailComponent extends EditComponentBase<UserViewModel> {
    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "user";
    }
}