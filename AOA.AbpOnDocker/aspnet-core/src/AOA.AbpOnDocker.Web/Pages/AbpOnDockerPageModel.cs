using AOA.AbpOnDocker.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AOA.AbpOnDocker.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpOnDockerPageModel : AbpPageModel
    {
        protected AbpOnDockerPageModel()
        {
            LocalizationResourceType = typeof(AbpOnDockerResource);
        }
    }
}