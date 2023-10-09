import { Component, Injector, ViewChild } from '@angular/core';
import { environment } from "@env/environment";
import { TreeTableQueryComponentBase } from "util-angular";
import { ResourceQuery } from '../resource/model/resource-query';
import { ApiResourceViewModel } from "../api-resource/model/api-resource-view-model";
import { ApplicationViewModel } from "../application/model/application-view-model";
import { ApplicationSelectComponent } from 'util-platform/application-select';

/**
 * Api资源选择页
 */
@Component({
    selector: 'api-resource-select',
    templateUrl: environment.production ? './html/api-resource.component.html' : '/view/routes/identity/Operation/ApiResource'
})
export class ApiResourceSelectComponent extends TreeTableQueryComponentBase<ApiResourceViewModel, ResourceQuery>  {
    /**
     * 当前Api应用程序
     */
    selectedApplication: ApplicationViewModel;
    /**
     * 应用程序选择组件
     */
    @ViewChild(ApplicationSelectComponent) applicationSelect: ApplicationSelectComponent;

    /**
     * 初始化Api资源选择页
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
}