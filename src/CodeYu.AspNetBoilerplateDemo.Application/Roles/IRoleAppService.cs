using System.Threading.Tasks;
using Abp.Application.Services;
using CodeYu.AspNetBoilerplateDemo.Roles.Dto;

namespace CodeYu.AspNetBoilerplateDemo.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
