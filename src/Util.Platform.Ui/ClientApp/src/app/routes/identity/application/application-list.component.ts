import { Component, ChangeDetectionStrategy, OnInit, OnDestroy } from '@angular/core';
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
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/application-list.component.html',
    styles: [`
        .cardlist {
            .ant-col {
                padding:12px 12px
            }
            .ant-card {
                border-radius:8px;
                height:206px;
            }
            button {
                height:206px;
                border:dashed 1px #d9d9d9;
                border-radius:8px;
                color:rgba(0, 0, 0, 0.5);
                margin-bottom:16px;
            }
            .ant-card-body {
                padding:10px 24px 34px 24px;
                .ant-card-meta-description{
                    color:rgba(0, 0, 0, 0.88)
                }            
            }
            .ant-card-actions {
                background:none
            }
        }    
   `]
})
export class ApplicationListComponent extends QueryComponentBase<ApplicationQuery> implements OnInit, OnDestroy {
    /**
     * 数据加载器
     */
    loader: DataLoader<ApplicationViewModel>;
    /**
     * 头像加载状态
     */
    avatarLoading: boolean;
    /**
     * 数据容器
     */
    get container() {
        return this.loader.container;
    }

    /**
     * 初始化应用程序列表页
     */
    constructor() {
        super();
        this.loader = new DataLoader<ApplicationViewModel>();
        this.avatarLoading = true;
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
     * 获取创建标题
     */
    getCreateTitle() {
        return 'identity.application.create';
    }

    /**
     * 获取更新标题
     */
    getEditTitle() {
        return 'identity.application.update';
    }

    /**
     * 获取详情标题
     */
    getDetailTitle() {
        return 'identity.application.detail';
    }

    /**
     * 创建查询参数
     */
    createQuery() {
        let result = new ApplicationQuery();
        result.pageSize = 19;
        result.order = "CreationTime Desc";
        return result;
    }

    /**
     * 查询
     */
    query(button?) {
        this.loader.query({
            url: "application",
            param: this.queryParam,
            button: button
        });
    }

    /**
     * 删除
     * @param ids 标识列表
     */
    delete(ids?) {
        this.loader.delete({
            ids: ids
        });
    }

    /**
     * 刷新
     */
    refresh(button?) {
        this.queryParam = this.createQuery();
        this.loader.refresh(this.queryParam, button);
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

    /**
     * 头像加载完成事件
     */
    onLoadAvatar() {
        this.avatarLoading = false;
    }
}