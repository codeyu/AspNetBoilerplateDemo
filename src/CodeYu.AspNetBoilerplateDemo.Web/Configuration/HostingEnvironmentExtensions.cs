using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using CodeYu.AspNetBoilerplateDemo.Configuration;

namespace CodeYu.AspNetBoilerplateDemo.Web.Configuration
{
    public static class HostingEnvironmentExtensions
    {
        public static IConfigurationRoot GetAppConfiguration(this IHostingEnvironment env)
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}