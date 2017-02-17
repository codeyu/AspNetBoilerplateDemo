using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using CodeYu.AspNetBoilerplateDemo.Configuration;
using CodeYu.AspNetBoilerplateDemo.EntityFramework;

namespace CodeYu.AspNetBoilerplateDemo.Migrator
{
    [DependsOn(typeof(AspNetBoilerplateDemoEntityFrameworkModule))]
    public class AspNetBoilerplateDemoMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetBoilerplateDemoMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(AspNetBoilerplateDemoMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<AspNetBoilerplateDemoDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AspNetBoilerplateDemoConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}