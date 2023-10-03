import { loadManifest } from '@angular-architects/module-federation';
import { bootstrapConfig } from './app/config/bootstrap-config';

/**
 * 加载微前端配置并启动
 */
loadManifest(bootstrapConfig.manifestUrl)
    .catch(err => console.error(err))
    .then(_ => import('./bootstrap'))
    .catch(err => console.error(err));
