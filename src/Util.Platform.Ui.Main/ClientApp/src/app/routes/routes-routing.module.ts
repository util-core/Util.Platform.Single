import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { loadRemoteModule } from '@angular-architects/module-federation';
import { CustomManifest } from '../core/microfrontends/custom-manifest';
import { environment } from '@env/environment';
import { AuthGuard } from 'util-angular';
import { LayoutBasicComponent } from '../layout/basic/basic.component';
import { DashboardComponent } from './dashboard/dashboard.component';

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
