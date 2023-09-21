import { QueryParameter } from "util-angular";

/**
* 权限查询参数
*/
export class PermissionQuery extends QueryParameter {
    /**
     * 应用程序标识
     */
    applicationId;
   /**
    * 角色标识
    */
    roleId;
    /**
    * 资源标识
    */
    resourceId;
    /**
    * 拒绝
    */
    isDeny;
    /**
    * 临时
    */
    isTemporary;
    /**
    * 起始到期时间
    */
    beginExpirationTime;
    /**
    * 结束到期时间
    */
    endExpirationTime;
}
