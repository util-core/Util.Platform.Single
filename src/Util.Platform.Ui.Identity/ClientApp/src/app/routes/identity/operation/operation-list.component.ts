import { Component,Input, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { TableQueryComponentBase } from "util-angular";
import { ResourceQuery } from '../resource/model/resource-query';
import { OperationViewModel } from './model/operation-view-model';
import { OperationEditComponent } from './operation-edit.component';
import { OperationDetailComponent } from './operation-detail.component';
import { ModuleViewModel } from '../module/model/module-view-model';
import { CommonOperationListComponent } from '../common-operation/common-operation-list.component';

/**
 * 操作资源列表页
 */
@Component({
    selector: 'operation-list',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/operation'
})
export class OperationListComponent extends TableQueryComponentBase<OperationViewModel, ResourceQuery>  {    
    /**
     * 所属模块
     */
    @Input() module: ModuleViewModel;

    /**
     * 初始化操作资源列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 创建查询参数
     */
    protected createQuery() {
        let result = new ResourceQuery();
        if (this.module) {
            result.applicationId = this.module.applicationId;
            result.parentId = this.module.id;
        }        
        return result;
    }

    /**
     * 获取创建组件
     */
    getCreateComponent() {
        return OperationEditComponent;
    }

    /**
     * 获取创建数据
     */
    getCreateData() {
        return {
            data:this.module
        };
    }

    /**
     * 获取详情弹出框组件
     */
    getDetailComponent() {
        return OperationDetailComponent;
    }

    /**
     * 打开管理常用操作
     */
    openManageCommonOperation() {
        this.util.dialog.open({
            component: CommonOperationListComponent,
            centered: true,
            showFooter: false,
            disableClose:true,
            width:"80%"
        });
    }
}