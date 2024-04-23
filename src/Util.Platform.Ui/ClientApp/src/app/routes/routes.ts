import { Routes } from '@angular/router';
import { AuthGuard } from 'util-angular';
import { LayoutBasicComponent } from '../layout';

/**
 * 路由配置
 */
export const routes: Routes = [
    {
        path: '',
        component: LayoutBasicComponent,
        canActivate: [AuthGuard],
        canActivateChild: [AuthGuard],
        children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'dashboard', loadChildren: () => import('./dashboard/routes').then(t => t.routes) },
            { path: 'identity', loadChildren: () => import('./identity/identity.module').then(t => t.IdentityModule) }
        ]
    },
    { path: 'exception', loadChildren: () => import('./exception/routes').then(t => t.routes) },
    { path: '**', redirectTo: 'exception/404' }
];