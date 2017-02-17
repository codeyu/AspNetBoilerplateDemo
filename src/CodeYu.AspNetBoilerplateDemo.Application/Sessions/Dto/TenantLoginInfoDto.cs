using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CodeYu.AspNetBoilerplateDemo.MultiTenancy;

namespace CodeYu.AspNetBoilerplateDemo.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}