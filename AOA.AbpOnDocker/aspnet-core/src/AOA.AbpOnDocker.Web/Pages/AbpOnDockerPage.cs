using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AOA.AbpOnDocker.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AOA.AbpOnDocker.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits AOA.AbpOnDocker.Web.Pages.AbpOnDockerPage
     */
    public abstract class AbpOnDockerPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AbpOnDockerResource> L { get; set; }
    }
}
