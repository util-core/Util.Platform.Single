import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from 'util-angular';
import { environment } from '@env/environment';
import { LayoutBasicComponent } from '../layout/basic/basic.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { routes as identityRoutes } from "./identity/identity-routing.module";

const routes: Routes = [
    {
        path: '',
        component: LayoutBasicComponent,
        canActivate: [AuthGuard],
        canActivateChild: [AuthGuard],
        children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'dashboard', component: DashboardComponent, data: { title: '仪表盘', titleI18n: 'dashboard' } },
            { path: 'exception', loadChildren: () => import('./exception/exception.module').then(m => m.ExceptionModule) },
            { path: 'identity', children: identityRoutes }
        ]
    },
    { path: '**', redirectTo: 'exception/404' },
];

@NgModule({
    imports: [
        RouterModule.forRoot(
            routes, {
                useHash: environment.useHash,
                scrollPositionRestoration: 'top',
            }
        )],
    exports: [RouterModule],
})
export class RouteRoutingModule { }
