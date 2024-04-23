import { NzSafeAny } from 'ng-zorro-antd/core/types';

/**
 * window
 */
const win = window as NzSafeAny;

/**
 * ������������
 */
export const environment = {
    /**
     * �Ƿ���������
     */
    production: true,
    /**
     * �Ƿ�ʹ�ô� # �� url
     */
    useHash: false,
    /**
     * ��֤��������ַ
     */
    identityUrl: win.bootstrapConfig.identityUrl,
    /**
     * Api�˵��ַ
     */
    apiEndpointUrl: win.bootstrapConfig.apiEndpointUrl
};