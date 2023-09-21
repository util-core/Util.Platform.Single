import { ViewModel } from 'util-angular';

/**
 * 操作资源参数
 */
export class OperationViewModel extends ViewModel {
    /**
     * 应用程序标识
     */
    applicationId;    
    /**
     * 应用程序名称
     */
    applicationName;
    /**
     * Api应用程序标识
     */
    apiApplicationId;
    /**
     * 模块标识
     */
    moduleId;
    /**
     * 模块名称
     */
    moduleName;
    /**
     * 操作资源标识
     */
    uri;
    /**
     * 操作资源名称
     */
    name;
    /**
     * 备注
     */
    remark;
    /**
     * 是否绑定Api资源
     */
    isBindApi;
    /** 
     * 选中的Api资源标识列表
     */
    apiRourceIds:string[];
    /**
     * 启用
     */
    enabled;
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