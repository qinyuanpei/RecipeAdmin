using System.Threading.Tasks;

namespace RecipeAdmin.Data
{
    public interface IRecipeAdminDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
