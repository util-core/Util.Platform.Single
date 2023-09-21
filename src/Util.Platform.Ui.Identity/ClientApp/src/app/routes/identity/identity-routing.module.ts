import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ApplicationListComponent } from './application/application-list.component';
import { ClaimListComponent } from './claim/claim-list.component';
import { ResourceComponent } from './resource/resource.component';
import { RoleListComponent } from './role/role-list.component';
import { UserListComponent } from './user/user-list.component';

//路由配置
export const routes: Routes = [
    {
        path: '',
        children: [
            { path: 'application', component: ApplicationListComponent },
            { path: 'claim', component: ClaimListComponent },
            { path: 'resource', component: ResourceComponent },
            { path: 'role', component: RoleListComponent },
            { path: 'user', component: UserListComponent },
        ]
    }
];

/**
 * 系统权限路由模块
 */
@NgModule( {
    imports: [RouterModule.forChild( routes )]
} )
export class IdentityRoutingModule { }
