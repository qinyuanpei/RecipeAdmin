using RecipeAdmin.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RecipeAdmin.Permissions
{
    public class RecipeAdminPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(RecipeAdminPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(RecipeAdminPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<RecipeAdminResource>(name);
        }
    }
}
