using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AOA.AbpOnDocker.EntityFrameworkCore
{
    public static class AbpOnDockerDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpOnDocker(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpOnDockerConsts.DbTablePrefix + "YourEntities", AbpOnDockerConsts.DbSchema);

            //    //...
            //});
        }
    }
}