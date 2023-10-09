import { NgModule, Type } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AlainThemeModule } from '@delon/theme';
import { DelonACLModule } from '@delon/acl';
import { Shared_Zorro_Modules } from './shared-zorro.module';
import { Shared_Delon_Modules } from './shared-delon.module';
import { Shared_Platform_Modules } from './shared-platform.module';
import { UtilModule } from 'util-angular';
import { NgxTinymceModule } from 'ngx-tinymce';
import { IconSelectModule } from "./components/icon-select/icon-select.module";

const THIRDMODULES: Array<Type<void>> = [UtilModule, NgxTinymceModule,IconSelectModule];
const COMPONENTS: Array<Type<void>> = [];
const DIRECTIVES: Array<Type<void>> = [];

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        ReactiveFormsModule,
        AlainThemeModule.forChild(),
        DelonACLModule,
        ...Shared_Zorro_Modules,
        ...Shared_Delon_Modules,
        ...Shared_Platform_Modules,
        ...THIRDMODULES
    ],
    declarations: [
        ...COMPONENTS,
        ...DIRECTIVES
    ],
    exports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        AlainThemeModule,
        DelonACLModule,
        ...Shared_Zorro_Modules,
        ...Shared_Delon_Modules,
        ...Shared_Platform_Modules,
        ...THIRDMODULES,
        ...COMPONENTS,
        ...DIRECTIVES
    ]
})
export class SharedModule {
}