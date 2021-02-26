using RecipeAdmin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RecipeAdmin.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class RecipeAdminController : AbpController
    {
        protected RecipeAdminController()
        {
            LocalizationResource = typeof(RecipeAdminResource);
        }
    }
}