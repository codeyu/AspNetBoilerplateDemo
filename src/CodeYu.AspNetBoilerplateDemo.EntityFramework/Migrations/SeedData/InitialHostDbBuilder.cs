using CodeYu.AspNetBoilerplateDemo.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CodeYu.AspNetBoilerplateDemo.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AspNetBoilerplateDemoDbContext _context;

        public InitialHostDbBuilder(AspNetBoilerplateDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
