import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Demo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44381',
    redirectUri: baseUrl,
    clientId: 'Demo_App',
    responseType: 'code',
    scope: 'offline_access Demo',
  },
  apis: {
    default: {
      url: 'https://localhost:44381',
      rootNamespace: 'ELSA.Demo',
    },
  },
} as Environment;
