import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from 'util-angular';
import { environment } from '@env/environment';

// layout
import { LayoutBasicComponent } from '../layout/basic/basic.component';
import { LayoutPassportComponent } from '../layout/passport/passport.component';
// dashboard pages
import { DashboardComponent } from './dashboard/dashboard.component';
// single pages
import { CallbackComponent } from './passport/callback.component';
import { UserLockComponent } from './passport/lock/lock.component';
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
            // 业务子模块
            // { path: 'widgets', loadChildren: () => import('./widgets/widgets.module').then(m => m.WidgetsModule) },
        ]
    },
    // 空白布局
    // {
    //     path: 'blank',
    //     component: LayoutBlankComponent,
    //     children: [
    //     ]
    // },
    // passport
    {
        path: 'passport',
        component: LayoutPassportComponent,
        children: [
            { path: 'lock', component: UserLockComponent, data: { title: '锁屏', titleI18n: 'lock' } },
        ]
    },
    // 单页不包裹Layout
    { path: 'passport/callback/:type', component: CallbackComponent },
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
