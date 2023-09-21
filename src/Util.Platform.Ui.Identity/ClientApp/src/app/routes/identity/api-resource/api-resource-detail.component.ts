import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { ApiResourceViewModel } from './model/api-resource-view-model';

/**
 * Api资源详情页
 */
@Component({
    selector: 'api-resource-detail',
    templateUrl: environment.production ? './html/detail.component.html' : '/view/routes/identity/apiResource/detail'
})
export class ApiResourceDetailComponent extends EditComponentBase<ApiResourceViewModel> {
    /**
     * 初始化Api资源详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "apiResource";
    }
}