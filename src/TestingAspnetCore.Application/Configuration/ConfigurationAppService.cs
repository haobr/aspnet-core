using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestingAspnetCore.Configuration.Dto;

namespace TestingAspnetCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestingAspnetCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
