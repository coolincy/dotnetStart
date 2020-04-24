using AOA.AbpOnDocker.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AOA.AbpOnDocker.Permissions
{
    public class AbpOnDockerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpOnDockerPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpOnDockerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpOnDockerResource>(name);
        }
    }
}
