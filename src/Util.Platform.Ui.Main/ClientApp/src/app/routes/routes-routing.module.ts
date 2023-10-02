import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { loadRemoteModule } from '@angular-architects/module-federation';
import { CustomManifest } from '../microfrontends/custom-manifest';
import { environment } from '@env/environment';
import { AuthGuard } from 'util-angular';
// layout
import { LayoutBasicComponent } from '../layout/basic/basic.component';
import { LayoutPassportComponent } from '../layout/passport/passport.component';
// dashboard pages
import { DashboardComponent } from './dashboard/dashboard.component';
// single pages
import { CallbackComponent } from './passport/callback.component';
import { UserLockComponent } from './passport/lock/lock.component';

const routes: Routes = [
    {
        path: '',
        component: LayoutBasicComponent,
        canActivate: [AuthGuard],
        canActivateChild: [AuthGuard],
        children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'dashboard', component: DashboardComponent, data: { title: '仪表盘', titleI18n: 'dashboard' } },
            { path: 'exception', loadChildren: () => import('./exception/exception.module').then(m => m.ExceptionModule) }
        ]
    },
    {
        path: 'passport',
        component: LayoutPassportComponent,
        children: [
            { path: 'lock', component: UserLockComponent, data: { title: '锁屏', titleI18n: 'lock' } }
        ]
    },
    { path: 'passport/callback/:type', component: CallbackComponent },
    { path: '**', redirectTo: 'exception/404' }
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

/**
 * 创建带延迟加载的微前端路由参数
 * @param options 微前端参数
 */
export function buildRoutes(options: CustomManifest): Routes {
    const lazyRoutes: Routes = Object.keys(options).map(key => {
        const entry = options[key];
        return {
            path: entry.routePath,
            loadChildren: () =>
                loadRemoteModule({
                    type: 'manifest',
                    remoteName: key,
                    exposedModule: entry.exposedModule
                })
                .then(m => m[entry.ngModuleName])
        }
    });
    routes[0].children && routes[0].children.push(...lazyRoutes);
    return [...routes];
}
