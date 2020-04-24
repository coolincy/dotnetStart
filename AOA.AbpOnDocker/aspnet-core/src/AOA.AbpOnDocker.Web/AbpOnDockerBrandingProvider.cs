using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AOA.AbpOnDocker.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpOnDockerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpOnDocker";
    }
}
