using System.Threading.Tasks;

namespace AOA.AbpOnDocker.Data
{
    public interface IAbpOnDockerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
