import { NgModule, Type } from '@angular/core';
import { SharedModule } from '../shared';
// dashboard pages
import { DashboardComponent } from './dashboard/dashboard.component';
// single pages
import { CallbackComponent } from './passport/callback.component';
import { UserLockComponent } from './passport/lock/lock.component';
import { RouteRoutingModule } from './routes-routing.module';
import { IdentityModule } from "./identity/identity.module";

const COMPONENTS: Array<Type<void>> = [
    DashboardComponent,
    CallbackComponent,
    UserLockComponent
];

@NgModule({
    imports: [SharedModule, RouteRoutingModule, IdentityModule],
    declarations: COMPONENTS
})
export class RoutesModule {
}
