using System.Threading.Tasks;
using Abp.Application.Services;
using MRShop.Authorization.Accounts.Dto;

namespace MRShop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
