using Abp.Application.Features;
using sample.Authorization.Roles;
using sample.MultiTenancy;
using sample.Users;

namespace sample.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}