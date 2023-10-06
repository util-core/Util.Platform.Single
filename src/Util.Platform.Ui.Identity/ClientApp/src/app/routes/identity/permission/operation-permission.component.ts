import { Component, Injector, Input, ViewChild, AfterViewInit, OnDestroy, ChangeDetectionStrategy } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { map, filter, distinctUntilChanged } from 'rxjs/operators';
import { environment } from "@env/environment";
import { ComponentBase, TreeTableExtendDirective, I18nKeys } from "util-angular";
import { RoleViewModel } from "../role/model/role-view-model";
import { PermissionQuery } from '../permission/model/permission-query';
import { ApplicationViewModel } from "../application/model/application-view-model";
import { SavePermissionViewModel } from "./model/save-permission-view-model";
import { OperationPermissionViewModel } from './model/operation-permission-view-model';

/**
* 操作权限页
*/
@Component({
    selector: 'operation-permission',
    templateUrl: environment.production ? './html/operation-permission.component.html' : '/view/routes/identity/permission/operationPermission',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class OperationPermissionComponent extends ComponentBase implements AfterViewInit, OnDestroy {
    /**
     * 加载变更对象
     */
    private loadChange$ = new BehaviorSubject<ApplicationViewModel>(null);
    /**
     * 查询参数
     */
    queryParam: PermissionQuery;
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
     * 操作权限树形表格指令
     */
    @ViewChild("x_tb_operation_permission") treeTable: TreeTableExtendDirective<OperationPermissionViewModel>;

    /**
     * 初始化操作权限页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
        this.queryParam = new PermissionQuery();
        this.role = new RoleViewModel();
        this.application = new ApplicationViewModel();
        this.initLoad();
    }

    /**
     * 初始化加载操作
     */
    private initLoad() {
        this.loadChange$.pipe(
            map(application => application && application.id),
            filter(value => {
                return !this.util.helper.isEmpty(value);
            }),
            distinctUntilChanged()
        ).subscribe(applicationId => {
            this.queryParam.applicationId = applicationId;
            this.queryParam.roleId = this.role.id;
            this.queryParam.isDeny = this.isDeny;
            if (this.treeTable) {
                this.treeTable.query({
                    complete: () => {
                        this.util.changeDetector.detectChanges();
                    }
                });
            }
        });
    }

    /**
     * 初始化
     */
    ngAfterViewInit(): void {
        if (!this.role)
            return;
        if (!this.application)
            return;
        this.loadChange$.next(this.application);
    }

    /**
     * 清理
     */
    ngOnDestroy(): void {
        this.loadChange$.unsubscribe();
    }

    /**
     * 加载
     * @param application 应用程序
     */
    load(application: ApplicationViewModel) {
        this.application = application;
        this.loadChange$.next(application);
    }

    /**
     * 获取操作资源
     */
    getOperations(module: OperationPermissionViewModel) {
        if (!this.treeTable)
            return [];
        let result = this.treeTable.getChildren(module);
        return result.filter((children: OperationPermissionViewModel) => children.isOperation);
    }

    /**
     * 勾选操作
     */
    check(operation: OperationPermissionViewModel, module: OperationPermissionViewModel) {
        this.treeTable.toggle(operation);
        let operations = this.getOperations(module);
        if (operation.isBase) {
            if (this.treeTable.isChecked(operation))
                return;
            operations.forEach(item => {
                if (this.treeTable.isChecked(item))
                    this.treeTable.toggle(item);
            });
            return;
        }
        let baseOperation = operations.find((item: OperationPermissionViewModel) => item.isBase);
        this.treeTable.checkIds(baseOperation.id);
    }

    /**
     * 保存
     */
    save() {
        let model = new SavePermissionViewModel();
        model.applicationId = this.application.id;
        model.roleId = this.role.id;
        model.resourceIds = this.treeTable.getCheckedIds();
        let url = this.isDeny ? "operationPermission/denyPermissions" : "operationPermission/grantPermissions";
        this.util.form.submit({
            url: url,
            data: model,
            confirm: I18nKeys.saveConfirmation
        });
    }
}