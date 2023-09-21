import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { TableEditComponentBase } from "util-angular";
import { CommonOperationQuery } from './model/common-operation-query';
import { CommonOperationViewModel } from './model/common-operation-view-model';

/**
* 常用操作资源列表页
*/
@Component( {
    selector: 'common-operation-list',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/commonOperation',
} )
export class CommonOperationListComponent extends TableEditComponentBase<CommonOperationViewModel, CommonOperationQuery> {
    /**
     * 初始化常用操作资源列表页
     * @param injector 注入器
     */
    constructor( injector: Injector ) {
        super( injector );
    }

    /**
     * 创建参数
     */
    protected createModel() {
        let result = new CommonOperationViewModel();
        result.enabled = true;
        return result;
    }
}