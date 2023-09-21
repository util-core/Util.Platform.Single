import { Component, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { ModuleViewModel } from './model/module-view-model';

/**
 * 模块详情页
 */
@Component({
    selector: 'module-detail',
    templateUrl: environment.production ? './html/detail.component.html' : '/view/routes/identity/module/detail'
})
export class ModuleDetailComponent extends EditComponentBase<ModuleViewModel> {
    /**
     * 初始化模块详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "module";
    }
}