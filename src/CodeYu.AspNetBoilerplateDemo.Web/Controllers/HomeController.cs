using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeYu.AspNetBoilerplateDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AspNetBoilerplateDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}