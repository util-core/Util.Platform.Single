import { Component, ChangeDetectionStrategy } from '@angular/core';
import { TableEditComponentBase } from 'util-angular';
import { ClaimQuery } from './model/claim-query';
import { ClaimViewModel } from './model/claim-view-model';

/**
 * 声明列表页
 */
@Component({
    selector: 'claim-list',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './html/claim-list.component.html'
})
export class ClaimListComponent extends TableEditComponentBase<ClaimViewModel, ClaimQuery>  {
    /**
     * 创建参数
     */
    protected createModel() {
        let result = new ClaimViewModel();
        result.enabled = true;
        result.sortId = 0;
        result.creationTime = new Date();
        result.lastModificationTime = new Date();
        return result;
    }
}