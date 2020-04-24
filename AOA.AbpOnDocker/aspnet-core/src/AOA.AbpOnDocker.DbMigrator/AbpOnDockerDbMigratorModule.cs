using AOA.AbpOnDocker.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AOA.AbpOnDocker.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpOnDockerEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpOnDockerApplicationContractsModule)
        )]
    public class AbpOnDockerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
