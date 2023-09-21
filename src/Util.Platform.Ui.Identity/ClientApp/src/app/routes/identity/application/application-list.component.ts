import { Component, Injector, OnInit, OnDestroy } from '@angular/core';
import { environment } from "@env/environment";
import { QueryComponentBase, DataLoader } from "util-angular";
import { ApplicationQuery } from './model/application-query';
import { ApplicationViewModel } from './model/application-view-model';
import { ApplicationEditComponent } from './application-edit.component';
import { ApplicationDetailComponent } from './application-detail.component';

/**
 * 应用程序列表页
 */
@Component({
    selector: 'application-list',
    templateUrl: environment.production ? './html/index.component.html' : '/view/routes/identity/application'
})
export class ApplicationListComponent extends QueryComponentBase<ApplicationQuery> implements OnInit, OnDestroy {    
    /**
     * 数据加载器
     */
    loader: DataLoader<ApplicationViewModel>;
    /**
     * 数据容器
     */
    get container() {
        return this.loader.container;
    }

    /**
     * 初始化应用程序列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
        this.loader = new DataLoader<ApplicationViewModel>(this.util);
    }

    /**
     * 创建查询参数
     */
    createQuery() {
        let result = new ApplicationQuery();
        result.pageSize = 12;
        return result;
    }

    /**
     * 初始化
     */
    ngOnInit() {
        super.ngOnInit();
        this.query();
    }

    /**
     * 清理
     */
    ngOnDestroy() {
        this.loader.clear();
    }

    /**
     * 获取创建弹出框组件
     */
    getCreateComponent() {
        return ApplicationEditComponent;
    }

    /**
     * 获取详情弹出框组件
     */
    getDetailComponent() {
        return ApplicationDetailComponent;
    }

    /**
     * 查询
     */
    query(button?) {
        this.loader.initOnScrollToBottomLoad();
        this.loader.query({
            page:1,
            url: "application",
            param: this.queryParam,
            button: button
        });
    }

    /**
     * 删除
     * @param ids 标识列表
     */
    delete(ids) {
        this.loader.delete({
            ids: ids
        });
    }

    /**
     * 刷新
     */
    refresh(button?) {
        this.loader.clear();
        this.queryParam = this.createQuery();
        this.query(button);
    }

    /**
     * 刷新实体
     */
    refreshByModel(model) {
        this.container.refreshData(model);
    }

    /**
     * 获取头像地址
     */
    getAvatarUrl(model: ApplicationViewModel) {
        return this.util.url.query({ text: model.name }).get("avatar");
    }
}