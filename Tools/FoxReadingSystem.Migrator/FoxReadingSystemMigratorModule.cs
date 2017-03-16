using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using FoxReadingSystem.EntityFramework;

namespace FoxReadingSystem.Migrator
{
    [DependsOn(typeof(FoxReadingSystemDataModule))]
    public class FoxReadingSystemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<FoxReadingSystemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}