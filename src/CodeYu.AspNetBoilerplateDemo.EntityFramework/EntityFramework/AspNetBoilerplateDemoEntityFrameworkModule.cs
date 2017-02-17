using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace CodeYu.AspNetBoilerplateDemo.EntityFramework
{
    [DependsOn(
        typeof(AspNetBoilerplateDemoCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class AspNetBoilerplateDemoEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AspNetBoilerplateDemoDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}