using System;
using System.Collections.Generic;
using System.Text;
using RecipeAdmin.Localization;
using Volo.Abp.Application.Services;

namespace RecipeAdmin
{
    /* Inherit your application services from this class.
     */
    public abstract class RecipeAdminAppService : ApplicationService
    {
        protected RecipeAdminAppService()
        {
            LocalizationResource = typeof(RecipeAdminResource);
        }
    }
}
