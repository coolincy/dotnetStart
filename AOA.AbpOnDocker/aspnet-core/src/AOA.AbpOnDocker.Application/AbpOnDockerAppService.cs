using System;
using System.Collections.Generic;
using System.Text;
using AOA.AbpOnDocker.Localization;
using Volo.Abp.Application.Services;

namespace AOA.AbpOnDocker
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpOnDockerAppService : ApplicationService
    {
        protected AbpOnDockerAppService()
        {
            LocalizationResource = typeof(AbpOnDockerResource);
        }
    }
}
