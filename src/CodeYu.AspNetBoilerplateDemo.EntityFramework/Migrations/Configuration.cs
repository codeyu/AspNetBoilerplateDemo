using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using CodeYu.AspNetBoilerplateDemo.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace CodeYu.AspNetBoilerplateDemo.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<AspNetBoilerplateDemo.EntityFramework.AspNetBoilerplateDemoDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AspNetBoilerplateDemo";
        }

        protected override void Seed(AspNetBoilerplateDemo.EntityFramework.AspNetBoilerplateDemoDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
