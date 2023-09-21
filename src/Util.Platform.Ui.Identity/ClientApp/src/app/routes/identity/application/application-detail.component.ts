import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from 'util-angular';
import { ApplicationViewModel } from './model/application-view-model';

/**
 * 应用程序详情页
 */
@Component({
    selector: 'application-detail',
    templateUrl: environment.production ? './html/detail.component.html' : '/view/routes/identity/application/detail'
})
export class ApplicationDetailComponent extends EditComponentBase<ApplicationViewModel> {
    /**
     * 初始化应用程序详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "application";
    }
}