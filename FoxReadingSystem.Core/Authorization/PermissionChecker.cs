using Abp.Authorization;
using FoxReadingSystem.Authorization.Roles;
using FoxReadingSystem.MultiTenancy;
using FoxReadingSystem.Users;

namespace FoxReadingSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
