using Abp.AspNetCore.Mvc.Authorization;
using CodeYu.AspNetBoilerplateDemo.Authorization;
using CodeYu.AspNetBoilerplateDemo.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace CodeYu.AspNetBoilerplateDemo.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : AspNetBoilerplateDemoControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}