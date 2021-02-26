using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RecipeAdmin.Data
{
    /* This is used if database provider does't define
     * IRecipeAdminDbSchemaMigrator implementation.
     */
    public class NullRecipeAdminDbSchemaMigrator : IRecipeAdminDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}