using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AOA.AbpOnDocker.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpOnDockerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpOnDockerConsoleApiClientModule : AbpModule
    {
        
    }
}
