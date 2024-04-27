import { Component, ChangeDetectionStrategy } from '@angular/core';
import { EditComponentBase } from "util-angular";
import { OperationViewModel } from './model/operation-view-model';
import { OperationQuery } from './model/operation-query';

/**
 * 操作资源详情页
 */
@Component({
    selector: 'operation-detail',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/operation-detail.component.html'
})
export class OperationDetailComponent extends EditComponentBase<OperationViewModel> {
    /**
     * 查询参数
     */
    queryParam: OperationQuery;

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