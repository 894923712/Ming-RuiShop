using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MRShop.Roles.Dto;

namespace MRShop.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
