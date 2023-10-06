import { TreeViewModel } from 'util-angular';

/**
 * 操作权限参数
 */
export class OperationPermissionViewModel extends TreeViewModel {
    /**
     * 资源名称
     */
    name;
    /**
     * 是否操作资源
     */
    isOperation: boolean;
    /**
     * 是否基础资源
     */
    isBase: boolean;
}