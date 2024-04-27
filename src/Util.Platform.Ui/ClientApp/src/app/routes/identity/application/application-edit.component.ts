import { Component, ChangeDetectionStrategy } from '@angular/core';
import { EditComponentBase } from "util-angular";
import { ApplicationViewModel } from './model/application-view-model';

/**
 * 应用程序编辑页
 */
@Component( {
    selector: 'application-edit',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/application-edit.component.html'
} )
export class ApplicationEditComponent extends EditComponentBase<ApplicationViewModel> {
    /**
     * 是否客户端
     */
    isClient: boolean;

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