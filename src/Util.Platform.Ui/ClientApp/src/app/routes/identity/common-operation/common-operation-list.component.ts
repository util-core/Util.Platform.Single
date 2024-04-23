import { Component, ChangeDetectionStrategy, Injector, ViewEncapsulation } from '@angular/core';
import { environment } from "@env/environment";
import { TableEditComponentBase } from "util-angular";
import { CommonOperationQuery } from './model/common-operation-query';
import { CommonOperationViewModel } from './model/common-operation-view-model';

/**
* 常用操作资源列表页
*/
@Component( {
    selector: 'common-operation-list',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/common-operation-list.component.html'
} )
export class CommonOperationListComponent extends TableEditComponentBase<CommonOperationViewModel, CommonOperationQuery> {
    /**
     * 创建参数
     */
    protected createModel() {
        let result = new CommonOperationViewModel();
        result.enabled = true;
        return result;
    }
}