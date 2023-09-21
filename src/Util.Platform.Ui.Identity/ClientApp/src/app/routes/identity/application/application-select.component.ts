import { Component, Injector, OnInit,Input, Output, EventEmitter } from '@angular/core';
import { environment } from "@env/environment";
import { ComponentBase } from "util-angular";
import { ApplicationViewModel } from './model/application-view-model';

/**
 * 公共组件 - 选择应用程序
 */
@Component({
    selector: 'application-select',
    templateUrl: environment.production ? './html/select.component.html' : '/view/routes/identity/application/select'
})
export class ApplicationSelectComponent extends ComponentBase implements OnInit {
    /**
     * 应用程序列表
     */
    @Input()  list: ApplicationViewModel[];
    /**
     * 当前应用程序
     */
    selected: ApplicationViewModel;
    /**
     * 是否仅加载Api应用程序
     */
    @Input() loadApiOnly: boolean;
    /**
     * 是否仅加载非Api应用程序
     */
    @Input() loadNonApiOnly: boolean;
    /**
     * 单击事件
     */
    @Output() onClick = new EventEmitter<ApplicationViewModel>();

    /**
     * 初始化选择应用程序
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
        this.list = new Array<ApplicationViewModel>();
    }

    /**
     * 初始化
     */
    ngOnInit() {
        if (this.list && this.list.length > 0)
            return;
        this.loadApplications();
    }

    /**
     * 加载应用程序列表
     */
    loadApplications() {
        let url = "application/all";
        if (this.loadApiOnly )
            url = "application/apis";
        if (this.loadNonApiOnly)
            url = "application/non-apis";
        this.util.webapi.get<ApplicationViewModel[]>(url).loading().handle({
            ok: result => {
                this.list = result;
                this.selectApplication();
            }
        });
    }

    /**
     * 选择当前应用程序
     */
    private selectApplication() {
        if (!this.list || this.list.length === 0)
            return;
        this.clickItem(this.list[0]);
    }

    /**
     * 单击
     */
    clickItem(item) {
        this.selected = item;
        this.onClick.emit(item);
    }
}