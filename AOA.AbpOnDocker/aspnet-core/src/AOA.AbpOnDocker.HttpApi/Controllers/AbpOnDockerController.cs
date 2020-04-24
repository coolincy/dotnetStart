using AOA.AbpOnDocker.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AOA.AbpOnDocker.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpOnDockerController : AbpController
    {
        protected AbpOnDockerController()
        {
            LocalizationResource = typeof(AbpOnDockerResource);
        }
    }
}