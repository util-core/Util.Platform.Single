import { NgModule, Type } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgxTinymceModule } from 'ngx-tinymce';
import { AlainThemeModule } from '@delon/theme';
import { DelonACLModule } from '@delon/acl';
import { Delon_Modules } from './delon.module';
import { Zorro_Modules } from './zorro.module';
import { Platform_Modules } from './platform.module';
import { UtilModule } from 'util-angular';

/**
 * 模块
 */
const Modules: Array<Type<void>> = [UtilModule, NgxTinymceModule];
/**
 * 组件
 */
const Components: Array<Type<void>> = [];
/**
 * 指令
 */
const Directives: Array<Type<void>> = [];

/**
 * 共享模块
 */
@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        ReactiveFormsModule,
        AlainThemeModule.forChild(),
        DelonACLModule,
        ...Delon_Modules,
        ...Zorro_Modules,
        ...Platform_Modules,
        ...Modules,
        ...Components,
        ...Directives
    ],
    exports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        AlainThemeModule,
        DelonACLModule,
        ...Delon_Modules,
        ...Zorro_Modules,
        ...Platform_Modules,
        ...Modules,
        ...Components,
        ...Directives
    ]
})
export class SharedModule {
}
