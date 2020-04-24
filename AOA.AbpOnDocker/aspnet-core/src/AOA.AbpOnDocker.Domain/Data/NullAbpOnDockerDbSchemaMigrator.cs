using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AOA.AbpOnDocker.Data
{
    /* This is used if database provider does't define
     * IAbpOnDockerDbSchemaMigrator implementation.
     */
    public class NullAbpOnDockerDbSchemaMigrator : IAbpOnDockerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}