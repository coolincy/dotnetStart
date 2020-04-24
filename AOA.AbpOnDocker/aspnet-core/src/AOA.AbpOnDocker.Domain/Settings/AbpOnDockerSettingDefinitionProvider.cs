using Volo.Abp.Settings;

namespace AOA.AbpOnDocker.Settings
{
    public class AbpOnDockerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpOnDockerSettings.MySetting1));
        }
    }
}
