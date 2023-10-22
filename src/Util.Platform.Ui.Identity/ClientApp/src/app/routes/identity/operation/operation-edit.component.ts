import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { ModuleViewModel } from '../module/model/module-view-model';
import { ResourceQuery } from '../resource/model/resource-query';
import { OperationViewModel } from './model/operation-view-model';

/**
 * 操作资源编辑页
 */
@Component( {
    selector: 'operation-edit',
    templateUrl: environment.production ? './html/edit.component.html' : '/view/routes/identity/operation/edit'
} )
export class OperationEditComponent extends EditComponentBase<OperationViewModel> {
    /**
     * 查询参数
     */
    queryParam: ResourceQuery;

    /**
     * 初始化操作资源编辑页
     * @param injector 注入器
     */
    constructor( injector: Injector ) {
        super( injector );
    }

    /**
     * 初始化
     */
    ngOnInit() {
        super.ngOnInit();        
        this.queryParam = this.createQuery();
    }

    /**
     * 创建模型
     */
    createModel() {
        let result = new OperationViewModel();
        let module = <ModuleViewModel>this.data;
        result.applicationId = module.applicationId;
        result.applicationName = module.applicationName;
        result.moduleId = module.id;
        result.moduleName = module.name;
        result.enabled = true;
        return result;
    }

    /**
     * 创建查询参数
     */
    protected createQuery() {
        let result = new ResourceQuery();
        let module = <ModuleViewModel>this.data;
        result.applicationId = module.applicationId;
        result.parentId = module.id;
        return result;
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "operation";
    }
}