import { default as ngLang } from '@angular/common/locales/zh';
import { EnvironmentProviders } from '@angular/core';
import { zhCN as dateLang } from 'date-fns/locale';
import { zh_CN as zorroLang } from 'ng-zorro-antd/i18n';
import { AlainConfig } from '@delon/util/config';
import { AlainProvideLang, provideAlain, zh_CN as delonLang } from '@delon/theme';
import { provideReuseTabConfig } from '@delon/abc/reuse-tab';
import { I18NService } from '@core';

//ng-alain配置
const alainConfig: AlainConfig = {
    pageHeader: { homeI18n: 'home' },
    themeResponsive: {
        rules : {
            1: { xs: 24 },
            2: { xs: 24, sm: 12 },
            3: { xs: 24, sm: 12, md: 12, lg: 8 },
            4: { xs: 24, sm: 12, md: 12, lg: 8, xl: 8, xxl: 6 },
            5: { xs: 24, sm: 12, md: 12, lg: 8, xl: 8, xxl: 6 },
            6: { xs: 24, sm: 12, md: 12, lg: 8, xl: 6, xxl: 4 }
        }        
    }
};

//默认语言配置
const defaultLang: AlainProvideLang = {
    abbr: 'zh-CN',
    ng: ngLang,
    zorro: zorroLang,
    date: dateLang,
    delon: delonLang
};

/**
 * ng-alain配置提供器
 */
export const provideNgAlain = (): EnvironmentProviders[] => {
    return [
        provideReuseTabConfig(),
        provideAlain({ config: alainConfig, defaultLang, i18nClass: I18NService })
    ];
}