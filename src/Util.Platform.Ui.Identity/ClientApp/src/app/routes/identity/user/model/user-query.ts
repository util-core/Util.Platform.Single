import { QueryParameter } from "util-angular";

/**
* 用户查询参数
*/
export class UserQuery extends QueryParameter {
    /**
    * 角色标识
    */
    roleId;
    /**
     * 排除的角色标识
     */
    exceptRoleId;
    /**
     * 用户名
     */
    userName;
    /**
    * 安全邮箱
    */
    email;
    /**
    * 安全手机号
    */
    phoneNumber;
    /**
    * 是否启用
    */
    enabled;
    /**
    * 备注
    */
    remark;
}
