import { NgModule } from '@angular/core';
import { SharedModule } from '../../shared';
import { IdentityRoutingModule } from './identity-routing.module';

import { ApplicationListComponent } from './application/application-list.component';
import { ApplicationEditComponent } from './application/application-edit.component';
import { ApplicationDetailComponent } from './application/application-detail.component';

import { ClaimListComponent } from './claim/claim-list.component';

import { ResourceComponent } from './resource/resource.component';

import { CommonOperationListComponent } from './common-operation/common-operation-list.component';

import { ModuleListComponent } from "./module/module-list.component";
import { ModuleEditComponent } from "./module/module-edit.component";
import { ModuleDetailComponent } from "./module/module-detail.component";

import { OperationListComponent } from './operation/operation-list.component';
import { OperationEditComponent } from './operation/operation-edit.component';
import { OperationDetailComponent } from './operation/operation-detail.component';
import { ApiResourceSelectComponent } from './operation/api-resource-select.component';

import { IdentityResourceListComponent } from './identity-resource/identity-resource-list.component';
import { IdentityResourceEditComponent } from './identity-resource/identity-resource-edit.component';
import { IdentityResourceDetailComponent } from './identity-resource/identity-resource-detail.component';

import { ApiResourceListComponent } from './api-resource/api-resource-list.component';
import { ApiResourceEditComponent } from './api-resource/api-resource-edit.component';
import { ApiResourceDetailComponent } from './api-resource/api-resource-detail.component';

import { RoleListComponent } from './role/role-list.component';
import { RoleEditComponent } from './role/role-edit.component';
import { RoleDetailComponent } from './role/role-detail.component';
import { RoleUsersComponent } from './role/role-users.component';
import { SelectUsersComponent } from './role/select-users.component';

import { UserListComponent } from './user/user-list.component';
import { UserEditComponent } from './user/user-edit.component';
import { UserDetailComponent } from './user/user-detail.component';

import { PermissionComponent } from './permission/index.component';
import { ResourcesPermissionComponent } from './permission/resouces-permission.component';
import { OperationPermissionComponent } from './permission/operation-permission.component';
import { ApiPermissionComponent } from './permission/api-permission.component';

/**
 * 系统权限模块
 */
@NgModule( {
    declarations: [
        ApplicationListComponent, ApplicationEditComponent, ApplicationDetailComponent,
        ClaimListComponent, ResourceComponent, CommonOperationListComponent,
        ModuleListComponent, ModuleEditComponent, ModuleDetailComponent,
        OperationListComponent, OperationEditComponent, OperationDetailComponent, ApiResourceSelectComponent,
        IdentityResourceListComponent, IdentityResourceEditComponent, IdentityResourceDetailComponent,
        ApiResourceListComponent, ApiResourceEditComponent, ApiResourceDetailComponent,
        RoleListComponent, RoleEditComponent, RoleDetailComponent, RoleUsersComponent, SelectUsersComponent,
        UserListComponent, UserEditComponent, UserDetailComponent,
        PermissionComponent, ResourcesPermissionComponent, OperationPermissionComponent, ApiPermissionComponent
    ],
    imports: [
        SharedModule, IdentityRoutingModule
    ],
} )
export class IdentityModule {
}
