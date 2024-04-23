import { Component, ChangeDetectionStrategy, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { ApiResourceViewModel } from './model/api-resource-view-model';

/**
 * Api资源详情页
 */
@Component({
    selector: 'api-resource-detail',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/api-resource-detail.component.html'
})
export class ApiResourceDetailComponent extends EditComponentBase<ApiResourceViewModel> {
    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "apiResource";
    }
}