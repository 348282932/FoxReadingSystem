using System.Linq;
using FoxReadingSystem.EntityFramework;
using FoxReadingSystem.MultiTenancy;

namespace FoxReadingSystem.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly FoxReadingSystemDbContext _context;

        public DefaultTenantCreator(FoxReadingSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
