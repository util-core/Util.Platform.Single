import { Component, Injector, Input, ViewChild, AfterViewInit, ChangeDetectionStrategy, DestroyRef, inject } from '@angular/core';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';
import { map, filter, distinctUntilChanged } from 'rxjs/operators';
import { environment } from "@env/environment";
import { ComponentBase, TreeTableExtendDirective, I18nKeys } from "util-angular";
import { RoleViewModel } from "../role/model/role-view-model";
import { PermissionQuery } from '../permission/model/permission-query';
import { ApplicationViewModel } from "../application/model/application-view-model";
import { SavePermissionViewModel } from "./model/save-permission-view-model";
import { ApiResourceViewModel } from "../api-resource/model/api-resource-view-model";

/**
* Api权限页
*/
@Component({
    selector: 'api-permission',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/api-permission.component.html'    
})
export class ApiPermissionComponent extends ComponentBase implements AfterViewInit {
    /**
     * 清理对象
     */
    private readonly destroy$ = inject(DestroyRef);
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
     * Api权限树形表格指令
     */
    @ViewChild("x_tb") treeTable: TreeTableExtendDirective<ApiResourceViewModel>;

    /**
     * 初始化操作权限页
     */
    constructor() {
        super();
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
            takeUntilDestroyed(this.destroy$),
            map(application => application && application.id),
            filter(value => !this.util.helper.isEmpty(value)),
            distinctUntilChanged()
        ).subscribe(applicationId => {
            this.queryParam.applicationId = applicationId;
            this.queryParam.roleId = this.role.id;
            this.queryParam.isDeny = this.isDeny;
            if (this.treeTable)
                this.treeTable.query();
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
     * 加载
     * @param application 应用程序
     */
    load(application: ApplicationViewModel) {
        this.application = application;
        this.loadChange$.next(application);
    }

    /**
     * 保存
     */
    save() {
        let model = new SavePermissionViewModel();
        model.applicationId = this.application.id;
        model.roleId = this.role.id;
        model.resourceIds = this.treeTable.getCheckedIds();
        let url = this.isDeny ? "apiPermission/denyPermissions" : "apiPermission/grantPermissions";
        this.util.form.submit({
            url: url,
            data: model,
            confirm: I18nKeys.saveConfirmation
        });
    }
}