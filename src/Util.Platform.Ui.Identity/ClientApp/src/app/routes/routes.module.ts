import { NgModule, Type } from '@angular/core';
import { SharedModule } from '../shared';
import { DashboardComponent } from './dashboard/dashboard.component';
import { RouteRoutingModule } from './routes-routing.module';
import { IdentityModule } from "./identity/identity.module";

const COMPONENTS: Array<Type<void>> = [
    DashboardComponent
];

@NgModule({
    imports: [SharedModule, RouteRoutingModule, IdentityModule],
    declarations: COMPONENTS
})
export class RoutesModule {
}
