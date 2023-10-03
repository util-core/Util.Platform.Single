import { NgModule, Type } from '@angular/core';
import { SharedModule } from '../shared';
import { DashboardComponent } from './dashboard/dashboard.component';
import { RouteRoutingModule } from './routes-routing.module';

const COMPONENTS: Array<Type<void>> = [
    DashboardComponent,
];

@NgModule({
    imports: [SharedModule, RouteRoutingModule],
    declarations: COMPONENTS,
})
export class RoutesModule {
}
