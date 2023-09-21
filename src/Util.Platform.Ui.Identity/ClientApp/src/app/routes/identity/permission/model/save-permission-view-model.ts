import { ViewModel } from 'util-angular';

/**
 * 保存权限参数
 */
export class SavePermissionViewModel extends ViewModel {
    /**
     * 应用程序标识
     */
    applicationId;
    /**
     * 角色标识
     */
    roleId;
    /**
     * 资源标识列表
     */
    resourceIds;
}