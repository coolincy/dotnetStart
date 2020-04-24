using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AOA.AbpOnDocker.Data;
using Volo.Abp.DependencyInjection;

namespace AOA.AbpOnDocker.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpOnDockerDbSchemaMigrator
        : IAbpOnDockerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpOnDockerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpOnDockerMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpOnDockerMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}