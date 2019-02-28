using System.Threading.Tasks;
using Abp.Application.Services;
using MRShop.Sessions.Dto;

namespace MRShop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
