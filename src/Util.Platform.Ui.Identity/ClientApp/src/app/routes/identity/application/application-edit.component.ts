import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { ApplicationViewModel } from './model/application-view-model';

/**
 * 应用程序编辑页
 */
@Component( {
    selector: 'application-edit',
    templateUrl: environment.production ? './html/edit.component.html' : '/view/routes/identity/application/edit'
} )
export class ApplicationEditComponent extends EditComponentBase<ApplicationViewModel> {
    /**
     * 是否客户端
     */
    isClient: boolean;

    /**
     * 初始化应用程序编辑页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 创建模型
     */
    protected createModel() {
        let result = new ApplicationViewModel();
        result.enabled = true;
        result.accessTokenLifetime = 3600;
        return result;
    }

    /**
     * 加载完成操作
     */
    onLoad(result) {
        this.isClient = result && result.isClient;
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "application";
    }

    /**
     * 切换显示客户端
     */
    toggleIsClient(value) {
        this.isClient = value;
    }
}