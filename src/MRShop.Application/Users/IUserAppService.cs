using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MRShop.Roles.Dto;
using MRShop.Users.Dto;

namespace MRShop.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}