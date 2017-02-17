using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CodeYu.AspNetBoilerplateDemo.MultiTenancy.Dto;

namespace CodeYu.AspNetBoilerplateDemo.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
