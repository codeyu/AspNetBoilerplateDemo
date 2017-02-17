using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using CodeYu.AspNetBoilerplateDemo.Authorization.Roles;
using CodeYu.AspNetBoilerplateDemo.Configuration;
using CodeYu.AspNetBoilerplateDemo.MultiTenancy;
using CodeYu.AspNetBoilerplateDemo.Users;
using CodeYu.AspNetBoilerplateDemo.Web;

namespace CodeYu.AspNetBoilerplateDemo.EntityFramework
{
    [DbConfigurationType(typeof(AspNetBoilerplateDemoDbConfiguration))]
    public class AspNetBoilerplateDemoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public AspNetBoilerplateDemoDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                AspNetBoilerplateDemoConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of AspNetBoilerplateDemoDbContext since ABP automatically handles it.
         */
        public AspNetBoilerplateDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public AspNetBoilerplateDemoDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public AspNetBoilerplateDemoDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class AspNetBoilerplateDemoDbConfiguration : DbConfiguration
    {
        public AspNetBoilerplateDemoDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
