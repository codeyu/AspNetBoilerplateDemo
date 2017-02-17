using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using CodeYu.AspNetBoilerplateDemo.Editions;
using CodeYu.AspNetBoilerplateDemo.Users;

namespace CodeYu.AspNetBoilerplateDemo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}