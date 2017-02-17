using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using CodeYu.AspNetBoilerplateDemo.Authorization;

namespace CodeYu.AspNetBoilerplateDemo
{
    [DependsOn(
        typeof(AspNetBoilerplateDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspNetBoilerplateDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AspNetBoilerplateDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}