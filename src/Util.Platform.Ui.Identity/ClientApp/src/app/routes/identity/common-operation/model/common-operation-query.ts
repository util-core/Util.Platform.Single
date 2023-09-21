import { QueryParameter } from "util-angular";

/**
* 常用操作资源查询参数
*/
export class CommonOperationQuery extends QueryParameter {
   /**
    * 操作名称
    */
    name;
    /**
    * 启用
    */
    enabled;
    /**
    * 备注
    */
    remark;
}
