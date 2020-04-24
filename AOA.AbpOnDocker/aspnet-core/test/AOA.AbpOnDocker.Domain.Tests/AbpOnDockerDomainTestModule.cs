using AOA.AbpOnDocker.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AOA.AbpOnDocker
{
    [DependsOn(
        typeof(AbpOnDockerEntityFrameworkCoreTestModule)
        )]
    public class AbpOnDockerDomainTestModule : AbpModule
    {

    }
}