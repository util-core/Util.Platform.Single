import { Component, Injector, ViewChild } from '@angular/core';
import { environment } from "@env/environment";
import { TreeTableQueryComponentBase } from "util-angular";
import { ResourceQuery } from '../resource/model/resource-query';
import { ApiResourceViewModel } from './model/api-resource-view-model';
import { ApplicationViewModel } from "../application/model/application-view-model";
import { ApiResourceEditComponent } from './api-resource-edit.component';
import { ApplicationSelectComponent } from '../application/application-select.component';
import { ApiResourceDetailComponent } from './api-resource-detail.component';

/**
 * Api资源列表页
 */
@Component({
    selector: 'api-resource-list',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/apiResource'
})
export class ApiResourceListComponent extends TreeTableQueryComponentBase<ApiResourceViewModel, ResourceQuery>  {
    /**
     * 当前应用程序
     */
    selectedApplication: ApplicationViewModel;
    /**
     * 应用程序选择组件
     */
    @ViewChild(ApplicationSelectComponent) applicationSelect: ApplicationSelectComponent;

    /**
     * 初始化Api资源列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
        this.selectedApplication = new ApplicationViewModel();
    }

    /**
     * 创建查询参数
     */
    protected createQuery() {
        let result = new ResourceQuery();
        if (this.selectedApplication)
            result.applicationId = this.selectedApplication.id;
        return result;
    }

    /**
     * 选择应用程序
     * @param application 应用程序
     */
    selectApplication(application: ApplicationViewModel) {
        this.selectedApplication = application;
        this.queryParam.applicationId = application.id;
        this.load();
    }

    /**
     * 获取创建弹出层组件
     */
    getCreateComponent() {
        return ApiResourceEditComponent;
    }

    /**
     * 获取创建弹出层数据
     */
    protected getCreateData(data?) {
        return {
            parent: data,
            applicationId: this.selectedApplication.id,
            applicationName: this.selectedApplication.name
        }
    }

    /**
     * 创建弹出框打开前回调函数
     */
    onCreateOpenBefore() {
        if (this.selectedApplication.id)
            return true;
        this.util.message.warn("app.selectApplication");
        return false;
    }

    /**
     * 获取更新弹出框数据
     */
    protected getEditData(data) {
        if (!data)
            return null;
        return {
            id: data.id,
            data: data,
            applicationId: this.selectedApplication.id,
            applicationName: this.selectedApplication.name
        };
    }

    /**
     * 获取详情弹出框组件
     */
    getDetailComponent() {
        return ApiResourceDetailComponent;
    }

    /**
     * 刷新
     */
    refresh() {
        this.applicationSelect.loadApplications();
        this.reset();
    }
}