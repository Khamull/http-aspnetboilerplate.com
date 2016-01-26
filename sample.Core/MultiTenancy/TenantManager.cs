using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using sample.Authorization.Roles;
using sample.Editions;
using sample.Users;

namespace sample.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}