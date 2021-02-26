using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RecipeAdmin
{
    [Dependency(ReplaceServices = true)]
    public class RecipeAdminBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "RecipeAdmin";
    }
}
