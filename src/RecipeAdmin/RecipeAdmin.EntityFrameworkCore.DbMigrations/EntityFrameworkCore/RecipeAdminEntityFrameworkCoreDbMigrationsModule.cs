using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace RecipeAdmin.EntityFrameworkCore
{
    [DependsOn(
        typeof(RecipeAdminEntityFrameworkCoreModule)
        )]
    public class RecipeAdminEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<RecipeAdminMigrationsDbContext>();
        }
    }
}
