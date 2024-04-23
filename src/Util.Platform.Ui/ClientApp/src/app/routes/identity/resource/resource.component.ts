import { Component, ChangeDetectionStrategy, ViewChild } from '@angular/core';
import { environment } from "@env/environment";
import { ComponentBase } from 'util-angular';
import { ModuleListComponent } from '../module/module-list.component';

/**
 * 资源页
 */
@Component({
    selector: 'resource',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/resource.component.html'
})
export class ResourceComponent extends ComponentBase {
    /**
     * 当前选项卡索引
     */
    selectedTabIndex: number;
    /**
     * 模块列表组件
     */
    @ViewChild(ModuleListComponent) modules: ModuleListComponent;

    /**
     * 路由复用标签刷新
     */
    _onReuseInit(type?) {
        if (type === "refresh")
            this.refresh();
    }

    /**
     * 刷新
     */
    refresh() {
        this.selectedTabIndex = 0;
        this.modules && this.modules.refresh();
        this.util.changeDetector.detectChanges();
    }
}