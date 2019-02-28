using System.Threading.Tasks;
using Abp.Application.Services;
using MRShop.Configuration.Dto;

namespace MRShop.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}