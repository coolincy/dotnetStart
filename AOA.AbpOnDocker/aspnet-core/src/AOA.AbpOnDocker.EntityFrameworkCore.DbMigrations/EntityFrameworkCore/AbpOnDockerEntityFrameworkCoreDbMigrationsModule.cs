using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AOA.AbpOnDocker.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpOnDockerEntityFrameworkCoreModule)
        )]
    public class AbpOnDockerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpOnDockerMigrationsDbContext>();
        }
    }
}
