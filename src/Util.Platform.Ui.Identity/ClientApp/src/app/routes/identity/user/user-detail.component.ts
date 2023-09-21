import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { UserViewModel } from './model/user-view-model';

/**
* 用户详情页
*/
@Component( {
selector: 'user-detail',
    templateUrl: environment.production ? './html/detail.component.html' : '/view/routes/identity/user/detail'
} )
export class UserDetailComponent extends EditComponentBase<UserViewModel> {
    /**
     * 初始化用户详情页
     * @param injector 注入器
     */
    constructor( injector: Injector ) {
        super( injector );
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "user";
    }
}