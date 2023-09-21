import { Component, Injector, Input,ViewChild } from '@angular/core';
import { environment } from "@env/environment";
import { ComponentBase } from "util-angular";
import { RoleViewModel } from "../role/model/role-view-model";
import { ApplicationViewModel } from "../application/model/application-view-model";
import { OperationPermissionComponent } from './operation-permission.component';
import { ApiPermissionComponent } from './api-permission.component';

/**
* 资源分类权限页
*/
@Component({
    selector: 'resources-permission',
    templateUrl: environment.production ? './html/resources-permission.component.html' : '/view/routes/identity/permission/resourcesPermission',
})
export class ResourcesPermissionComponent extends ComponentBase {
    /**
     * 当前选项卡索引
     */
    selectedTabIndex: number;
    /**
     * 角色参数
     */
    @Input() role: RoleViewModel;
    /**
     * 应用程序
     */
    @Input() application: ApplicationViewModel;
    /**
     * 是否拒绝
     */
    @Input() isDeny: boolean;
    /**
     * 操作权限
     */
    @ViewChild(OperationPermissionComponent) operationPermissionComponent: OperationPermissionComponent;
    /**
     * Api权限
     */
    @ViewChild(ApiPermissionComponent) apiPermissionComponent: ApiPermissionComponent;

    /**
     * 初始化资源分类权限页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
        this.role = new RoleViewModel();
        this.application = new ApplicationViewModel();
    }

    /**
     * 加载
     * @param application 应用程序
     */
    load(application: ApplicationViewModel) {
        this.application = application;
        this.selectedTabIndex = 0;
        if (this.operationPermissionComponent) {
            this.operationPermissionComponent.load(application);
            return;
        }
        if (this.apiPermissionComponent) {
            this.apiPermissionComponent.load(application);
            return;
        }
    }

    /**
     * 保存
     */
    save() {
        if (this.operationPermissionComponent) {
            this.operationPermissionComponent.save();
            return;
        }
        if (this.apiPermissionComponent) {
            this.apiPermissionComponent.save();
            return;
        }
    }
}