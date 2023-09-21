import { Component, ViewChild } from '@angular/core';
import { environment } from "@env/environment";
import { ModuleListComponent } from '../module/module-list.component';

/**
 * 资源页
 */
@Component({
    selector: 'resource',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/resource'
})
export class ResourceComponent  {
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
    }
}