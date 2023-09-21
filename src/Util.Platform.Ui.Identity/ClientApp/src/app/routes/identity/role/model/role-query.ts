import { QueryParameter } from "util-angular";

/**
* 角色查询参数
*/
export class RoleQuery extends QueryParameter {
    /**
     * 角色编码
     */
    code;
    /**
     * 角色名称
     */
    name;
    /**
     * 角色类型
     */
    type;
    /**
     * 启用
     */
    enabled;
    /**
     * 备注
     */
    remark;
}
