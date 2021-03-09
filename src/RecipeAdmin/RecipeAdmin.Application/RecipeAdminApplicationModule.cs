using Microsoft.Extensions.DependencyInjection;
using RecipeAdmin.Identity;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace RecipeAdmin
{
    [DependsOn(
        typeof(RecipeAdminDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(RecipeAdminApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    public class RecipeAdminApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IRoleManageAppService, RoleManageAppService>();
            context.Services.AddTransient<EfCoreIdentityRoleRepository>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<RecipeAdminApplicationModule>();
            });
        }
    }
}
