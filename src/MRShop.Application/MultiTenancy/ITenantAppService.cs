using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MRShop.MultiTenancy.Dto;

namespace MRShop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
