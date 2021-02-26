using Volo.Abp.Settings;

namespace RecipeAdmin.Settings
{
    public class RecipeAdminSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(RecipeAdminSettings.MySetting1));
        }
    }
}
