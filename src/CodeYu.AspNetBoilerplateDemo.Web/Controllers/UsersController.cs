using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using CodeYu.AspNetBoilerplateDemo.Authorization;
using CodeYu.AspNetBoilerplateDemo.Users;
using Microsoft.AspNetCore.Mvc;

namespace CodeYu.AspNetBoilerplateDemo.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : AspNetBoilerplateDemoControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}