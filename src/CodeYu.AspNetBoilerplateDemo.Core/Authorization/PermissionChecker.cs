using Abp.Authorization;
using CodeYu.AspNetBoilerplateDemo.Authorization.Roles;
using CodeYu.AspNetBoilerplateDemo.MultiTenancy;
using CodeYu.AspNetBoilerplateDemo.Users;

namespace CodeYu.AspNetBoilerplateDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
