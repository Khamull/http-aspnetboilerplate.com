using Abp.Authorization;
using sample.Authorization.Roles;
using sample.MultiTenancy;
using sample.Users;

namespace sample.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
