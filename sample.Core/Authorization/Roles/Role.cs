using Abp.Authorization.Roles;
using sample.MultiTenancy;
using sample.Users;

namespace sample.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}