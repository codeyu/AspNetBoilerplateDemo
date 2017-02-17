using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace CodeYu.AspNetBoilerplateDemo.Web.Controllers
{
    public abstract class AspNetBoilerplateDemoControllerBase: AbpController
    {
        protected AspNetBoilerplateDemoControllerBase()
        {
            LocalizationSourceName = AspNetBoilerplateDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}