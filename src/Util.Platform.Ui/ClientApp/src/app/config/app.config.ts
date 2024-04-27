import { provideHttpClient, withInterceptorsFromDi, withInterceptors } from '@angular/common/http';
import { ApplicationConfig } from '@angular/core';
import { provideAnimations } from '@angular/platform-browser/animations';
import { provideRouter, withComponentInputBinding, withInMemoryScrolling, withHashLocation, RouterFeatures, withViewTransitions } from '@angular/router';
import { environment } from '@env/environment';
import { languageInterceptorFn } from 'util-angular';
import { routes } from '../routes/routes';
import { provideNgZorro } from './zorro.config';
import { provideNgAlain } from './alain.config';
import { provideIcons } from './icon.config';
import { provideAuth } from './auth.config';
import { provideUtil } from './util.config';
import { provideShared } from './shared.config';
import { provideStartup } from '@core';

//路由设置
const routerFeatures: RouterFeatures[] = [
    withComponentInputBinding(),
    withViewTransitions(),
    withInMemoryScrolling({ scrollPositionRestoration: 'top' })
];
if (environment.useHash)
    routerFeatures.push(withHashLocation());

/**
 * 应用配置
 */
export const appConfig: ApplicationConfig = {
    providers: [
        provideHttpClient(
            withInterceptorsFromDi(),
            withInterceptors([languageInterceptorFn])
        ),
        provideAnimations(),
        provideRouter(routes, ...routerFeatures),
        provideNgZorro(),
        provideNgAlain(),
        provideIcons(),
        provideAuth(),
        provideUtil(),
        provideShared(),
        provideStartup()
    ]
};
