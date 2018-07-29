using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MetroStation.Configuration.Dto;

namespace MetroStation.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MetroStationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
