import { ViewModel } from "util-angular";

/**
 * 应用程序参数
 */
export class ApplicationViewModel extends ViewModel {
    /**
     * 初始化应用程序参数
     */
    constructor() {
        super();
        this.name = "";
    }

    /**
     * 应用程序编码
     */
    code;
    /**
     * 应用程序名称
     */
    name;
    /**
     * 启用
     */
    enabled;
    /**
    * 是否Api
    */
    isApi;
    /**
    * 是否客户端
    */
    isClient;
    /**
     * 访问令牌生存期
     */
    accessTokenLifetime;
    /**
     * 认证重定向地址
     */
    redirectUri;
    /**
     * 注销重定向地址
     */
    postLogoutRedirectUri;
    /**
     * 允许的授权类型
     */
    allowedGrantType;
    /**
     * 允许的授权类型
     */
    allowedGrantTypeDescription;
    /**
     * 允许的跨域来源
     */
    allowedCorsOrigins;
    /**
     * 允许的权限范围
     */
    allowedScopes;
    /**
     * 允许获取刷新令牌
     */
    allowOfflineAccess;
    /**
     * 备注
     */
    remark;
    /**
     * 创建时间
     */
    creationTime;
    /**
     * 创建人编号
     */
    creatorId;
    /**
     * 最后修改时间
     */
    lastModificationTime;
    /**
     * 最后修改人编号
     */
    lastModifierId;
    /**
     * 版本号
     */
    version;
}
