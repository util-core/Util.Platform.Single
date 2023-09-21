import { Component, Injector, Input, ViewChild } from '@angular/core';
import { environment } from "@env/environment";
import { ComponentBase } from "util-angular";
import { RoleViewModel } from "../role/model/role-view-model";
import { ApplicationViewModel } from "../application/model/application-view-model";
import { ResourcesPermissionComponent } from './resouces-permission.component';

/**
* 权限页
*/
@Component({
    selector: 'permission-index',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/permission',
})
export class PermissionComponent extends ComponentBase {
    /**
     * 当前应用程序
     */
    selectedApplication: ApplicationViewModel;
    /**
     * 当前选项卡索引
     */
    selectedTabIndex: number;
    /**
     * 角色参数
     */
    @Input() role: RoleViewModel;
    /**
     * 授予权限组件
     */
    @ViewChild("grantPermission") grantPermissionComponent: ResourcesPermissionComponent;
    /**
     * 拒绝权限组件
     */
    @ViewChild("denyPermission") denyPermissionComponent: ResourcesPermissionComponent;

    /**
     * 初始化权限页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
        this.role = new RoleViewModel();
        this.selectedApplication = new ApplicationViewModel();
        let param = this.util.dialog.getData<any>();
        if (param) {
            this.role = param.role;
        }
    }

    /**
     * 选择应用程序
     * @param application 应用程序
     */
    selectApplication(application: ApplicationViewModel) {
        this.selectedApplication = application;
        this.selectedTabIndex = 0;
        if (this.grantPermissionComponent) {
            this.grantPermissionComponent.load(application);
            return;
        }
    }

    /**
     * 保存
     */
    save() {
        if (this.grantPermissionComponent) {
            this.grantPermissionComponent.save();
            return;
        }
        this.denyPermissionComponent && this.denyPermissionComponent.save();
    }
}