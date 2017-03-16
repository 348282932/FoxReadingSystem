using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using FoxReadingSystem.EntityFramework;

namespace FoxReadingSystem
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(FoxReadingSystemCoreModule))]
    public class FoxReadingSystemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<FoxReadingSystemDbContext>());

            Configuration.DefaultNameOrConnectionString = "FoxReadingSystemEntities";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
