using Volo.Abp.Modularity;

namespace AOA.AbpOnDocker
{
    [DependsOn(
        typeof(AbpOnDockerApplicationModule),
        typeof(AbpOnDockerDomainTestModule)
        )]
    public class AbpOnDockerApplicationTestModule : AbpModule
    {

    }
}