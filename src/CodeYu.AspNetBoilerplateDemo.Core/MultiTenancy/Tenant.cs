using Abp.MultiTenancy;
using CodeYu.AspNetBoilerplateDemo.Users;

namespace CodeYu.AspNetBoilerplateDemo.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}