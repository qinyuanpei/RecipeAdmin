using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RecipeAdmin.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class RecipeAdminMigrationsDbContextFactory : IDesignTimeDbContextFactory<RecipeAdminMigrationsDbContext>
    {
        public RecipeAdminMigrationsDbContext CreateDbContext(string[] args)
        {
            RecipeAdminEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<RecipeAdminMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new RecipeAdminMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../RecipeAdmin.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
