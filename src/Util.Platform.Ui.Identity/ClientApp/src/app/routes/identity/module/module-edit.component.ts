import { Component, Injector, Input } from '@angular/core';
import { environment } from "@env/environment";
import { TreeEditComponentBase } from "util-angular";
import { ModuleViewModel } from './model/module-view-model';
import { ResourceQuery } from '../resource/model/resource-query';

/**
 * 模块编辑页
 */
@Component({
    selector: 'module-edit',
    templateUrl: environment.production ? './html/edit.component.html' : '/view/routes/identity/module/edit'
})
export class ModuleEditComponent extends TreeEditComponentBase<ModuleViewModel> {
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
     * 初始化模块编辑页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
        let param = this.util.dialog.getData<any>();
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
        let result = new ModuleViewModel();
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
        return "module";
    }

    /**
     * 选择图标
     */
    selectedIcon(icon) {
        this.model.icon = icon;
    }
}