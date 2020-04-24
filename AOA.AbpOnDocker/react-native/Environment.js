const ENV = {
  dev: {
    apiUrl: 'http://localhost:44354',
    oAuthConfig: {
      issuer: 'http://localhost:44354',
      clientId: 'AbpOnDocker_App',
      clientSecret: '1q2w3e*',
      scope: 'AbpOnDocker',
    },
    localization: {
      defaultResourceName: 'AbpOnDocker',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44354',
    oAuthConfig: {
      issuer: 'http://localhost:44354',
      clientId: 'AbpOnDocker_App',
      clientSecret: '1q2w3e*',
      scope: 'AbpOnDocker',
    },
    localization: {
      defaultResourceName: 'AbpOnDocker',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
