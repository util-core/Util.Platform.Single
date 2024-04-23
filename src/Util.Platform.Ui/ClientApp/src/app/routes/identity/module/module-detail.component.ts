import { Component, ChangeDetectionStrategy, Injector } from '@angular/core';
import { environment } from "@env/environment";
import { EditComponentBase } from "util-angular";
import { ModuleViewModel } from './model/module-view-model';

/**
 * 模块详情页
 */
@Component({
    selector: 'module-detail',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/module-detail.component.html'
})
export class ModuleDetailComponent extends EditComponentBase<ModuleViewModel> {
    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "module";
    }
}