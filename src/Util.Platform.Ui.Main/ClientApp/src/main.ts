import { loadManifest } from '@angular-architects/module-federation';
import { urlConfig } from './app/config/url-config';

/**
 * 加载微前端配置并启动
 */
loadManifest(urlConfig.microfrontendsManifestUrl)
  .catch(err => console.error(err))
  .then(_ => import('./bootstrap'))
  .catch(err => console.error(err));
