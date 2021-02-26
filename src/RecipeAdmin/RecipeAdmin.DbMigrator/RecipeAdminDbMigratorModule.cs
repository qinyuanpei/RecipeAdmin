using RecipeAdmin.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RecipeAdmin.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(RecipeAdminEntityFrameworkCoreDbMigrationsModule),
        typeof(RecipeAdminApplicationContractsModule)
        )]
    public class RecipeAdminDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
