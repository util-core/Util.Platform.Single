import { Component, ChangeDetectionStrategy, Input } from '@angular/core';
import { TreeEditComponentBase } from "util-angular";
import { ResourceQuery } from '../resource/model/resource-query';
import { ApiResourceViewModel } from './model/api-resource-view-model';

/**
 * Api资源编辑页
 */
@Component( {
    selector: 'api-resource-edit',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/api-resource-edit.component.html'
} )
export class ApiResourceEditComponent extends TreeEditComponentBase<ApiResourceViewModel> {
    /**
     * 查询参数
     */
    queryParam: ResourceQuery;
    /**
     * 应用程序标识
     */
    @Input() applicationId;
    /**
     * 应用程序名称
     */
    @Input() applicationName;

    /**
     * 初始化Api资源编辑页
     */
    constructor() {
        super();
        let param = this.util.drawer.getData<any>();
        if (param) {
            this.applicationId = param.applicationId;
            this.applicationName = param.applicationName;
        }
    }

    /**
     * 初始化
     */
    ngOnInit() {
        super.ngOnInit();
        this.model.applicationId = this.applicationId;
        this.queryParam = this.createQuery();
    }

    /**
     * 创建模型
     */
    createModel() {
        let result = new ApiResourceViewModel();
        result.enabled = true;
        return result;
    }

    /**
     * 创建查询参数
     */
    protected createQuery() {
        let result = new ResourceQuery();
        result.applicationId = this.applicationId;
        return result;
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "apiResource";
    }
}