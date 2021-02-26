using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace RecipeAdmin.EntityFrameworkCore
{
    public static class RecipeAdminDbContextModelCreatingExtensions
    {
        public static void ConfigureRecipeAdmin(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(RecipeAdminConsts.DbTablePrefix + "YourEntities", RecipeAdminConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}