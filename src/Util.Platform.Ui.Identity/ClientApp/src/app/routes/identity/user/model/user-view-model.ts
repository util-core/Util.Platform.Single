import { ViewModel } from "util-angular";

/**
* 用户参数
*/
export class UserViewModel extends ViewModel {
   /**
    * 用户名
    */
    userName;
   /**
    * 安全邮箱
    */
    email;
   /**
    * 邮箱是否已确认
    */
    emailConfirmed;
   /**
    * 安全手机号
    */
    phoneNumber;
   /**
    * 手机号是否已确认
    */
    phoneNumberConfirmed;
   /**
    * 密码
    */
    password;
   /**
    * 是否启用双因素认证
    */
    twoFactorEnabled;
   /**
    * 是否启用
    */
    enabled;
   /**
    * 冻结时间
    */
    disabledTime;
   /**
    * 是否启用锁定
    */
    lockoutEnabled;
   /**
    * 锁定截止
    */
    lockoutEnd;
   /**
    * 登录失败次数
    */
    accessFailedCount;
   /**
    * 登录次数
    */
    loginCount;
   /**
    * 注册Ip
    */
    registerIp;
   /**
    * 上次登陆时间
    */
    lastLoginTime;
   /**
    * 上次登陆Ip
    */
    lastLoginIp;
   /**
    * 本次登陆时间
    */
    currentLoginTime;
   /**
    * 本次登陆Ip
    */
    currentLoginIp;
   /**
    * 安全戳
    */
    securityStamp;
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
