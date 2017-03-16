using FoxReadingSystem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace FoxReadingSystem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly FoxReadingSystemDbContext _context;

        public InitialHostDbBuilder(FoxReadingSystemDbContext context)
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
