import { Manifest, RemoteConfig } from "@angular-architects/module-federation";

/**
 * 自定义远程配置
 */
export type CustomRemoteConfig = RemoteConfig & {
  /**
   * 导出模块
   */
  exposedModule: string;
  /**
   * 路由路径
   */
  routePath: string;
  /**
   * Angular模块名称
   */
  ngModuleName: string;
};

/**
 * 自定义远程配置清单
 */
export type CustomManifest = Manifest<CustomRemoteConfig>;
