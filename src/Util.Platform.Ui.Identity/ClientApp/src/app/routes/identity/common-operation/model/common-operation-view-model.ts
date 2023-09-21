import { ViewModel } from "util-angular";

/**
* 常用操作资源参数
*/
export class CommonOperationViewModel extends ViewModel {
   /**
    * 操作名称
    */
    name;
   /**
    * 启用
    */
    enabled;
    /**
    * 排序号
    */
    sortId;
   /**
    * 备注
    */
    remark;
   /**
    * 创建时间
    */
    creationTime;
   /**
    * 创建人标识
    */
    creatorId;
   /**
    * 最后修改时间
    */
    lastModificationTime;
   /**
    * 最后修改人标识
    */
    lastModifierId;
   /**
    * 版本号
    */
    version;
}
