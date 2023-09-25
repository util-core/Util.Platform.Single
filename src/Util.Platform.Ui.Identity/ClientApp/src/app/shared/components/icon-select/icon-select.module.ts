import { NgModule } from '@angular/core';
import {IconSelectComponent} from "./icon-select.component";
import {NzIconModule} from "ng-zorro-antd/icon";
import {NzButtonModule} from "ng-zorro-antd/button";
import {NzPopoverModule} from "ng-zorro-antd/popover";
import {NzInputModule} from "ng-zorro-antd/input";
import {NzCardModule} from "ng-zorro-antd/card";
import {NgFor, NgIf, NgStyle} from "@angular/common";
import {NzEmptyModule} from "ng-zorro-antd/empty";
import {NzPaginationModule} from "ng-zorro-antd/pagination";

const COMPONENTS = [IconSelectComponent];

@NgModule({
  imports: [NzIconModule, NzButtonModule, NzPopoverModule, NzInputModule, NzCardModule, NgIf, NgFor, NgStyle, NzEmptyModule, NzPaginationModule],
  declarations: COMPONENTS,
  exports: COMPONENTS
})
export class IconSelectModule {}
