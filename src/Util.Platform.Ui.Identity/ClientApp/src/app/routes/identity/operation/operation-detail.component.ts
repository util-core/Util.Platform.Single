import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { OperationViewModel } from './model/operation-view-model';
import { OperationQuery } from './model/operation-query';

/**
 * 操作资源详情页
 */
@Component({
    selector: 'operation-detail',
    templateUrl: environment.production ? './html/detail.component.html' : '/view/routes/identity/operation/detail'
})
export class OperationDetailComponent extends EditComponentBase<OperationViewModel> {
    /**
     * 查询参数
     */
    queryParam: OperationQuery;
    /**
     * 初始化操作资源详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 初始化
     */
    ngOnInit() {
        super.ngOnInit();
        this.queryParam = this.createQuery();
    }

    /**
     * 创建查询参数
     */
    protected createQuery() {
        let result = new OperationQuery();
        result.operationId = this.id;
        return result;
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "operation";
    }
}