using System.Reflection;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using CodeYu.AspNetBoilerplateDemo.Configuration;
using CodeYu.AspNetBoilerplateDemo.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Zero.Configuration;

namespace CodeYu.AspNetBoilerplateDemo.Web.Startup
{
    [DependsOn(
        typeof(AspNetBoilerplateDemoApplicationModule), 
        typeof(AspNetBoilerplateDemoEntityFrameworkModule), 
        typeof(AbpAspNetCoreModule))]
    public class AspNetBoilerplateDemoWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetBoilerplateDemoWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AspNetBoilerplateDemoConsts.ConnectionStringName);

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Navigation.Providers.Add<AspNetBoilerplateDemoNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AspNetBoilerplateDemoApplicationModule).Assembly
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}