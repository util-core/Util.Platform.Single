import { ViewModel } from "util-angular";

/**
* 角色参数
*/
export class RoleViewModel extends ViewModel {
   /**
    * 角色编码
    */
    code;
   /**
    * 角色名称
    */
    name;
   /**
    * 标准化角色名称
    */
    normalizedName;
   /**
    * 角色类型
    */
    type;
   /**
    * 管理员
    */
    isAdmin;
   /**
    * 启用
    */
    enabled;
   /**
    * 备注
    */
    remark;
   /**
    * 拼音简码
    */
    pinYin;
   /**
    * 签名
    */
    sign;
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
