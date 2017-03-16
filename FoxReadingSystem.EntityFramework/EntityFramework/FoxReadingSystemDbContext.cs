using System.Data.Common;
using Abp.Zero.EntityFramework;
using FoxReadingSystem.Authorization.Roles;
using FoxReadingSystem.MultiTenancy;
using FoxReadingSystem.Users;

namespace FoxReadingSystem.EntityFramework
{
    public class FoxReadingSystemDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public FoxReadingSystemDbContext()
            : base("FoxReadingSystemEntities")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FoxReadingSystemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FoxReadingSystemDbContext since ABP automatically handles it.
         */
        public FoxReadingSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public FoxReadingSystemDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
