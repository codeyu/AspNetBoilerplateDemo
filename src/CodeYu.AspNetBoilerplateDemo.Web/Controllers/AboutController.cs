using Microsoft.AspNetCore.Mvc;

namespace CodeYu.AspNetBoilerplateDemo.Web.Controllers
{
    public class AboutController : AspNetBoilerplateDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}