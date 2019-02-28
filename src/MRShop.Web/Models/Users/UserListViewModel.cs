using System.Collections.Generic;
using MRShop.Roles.Dto;
using MRShop.Users.Dto;

namespace MRShop.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}