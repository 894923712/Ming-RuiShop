using Abp.Authorization;
using MRShop.Authorization.Roles;
using MRShop.Authorization.Users;

namespace MRShop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
