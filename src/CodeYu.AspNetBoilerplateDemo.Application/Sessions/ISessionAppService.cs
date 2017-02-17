using System.Threading.Tasks;
using Abp.Application.Services;
using CodeYu.AspNetBoilerplateDemo.Sessions.Dto;

namespace CodeYu.AspNetBoilerplateDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
