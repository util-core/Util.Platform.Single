import { ViewModel } from 'util-angular';

/**
 * 身份资源参数
 */
export class IdentityResourceViewModel extends ViewModel {
    /**
     * 资源标识
     */
    uri;
    /**
     * 显示名称
     */
    name;
    /**
     * 描述
     */
    remark;
    /**
     * 启用
     */
    enabled;
    /**
     * 用户声明
     */
    claims;
    /**
     * 用户声明
     */
    claimsDisplay;
    /**
     * 排序号
     */
    sortId;
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