using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MRShop.Configuration.Dto;

namespace MRShop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MRShopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
