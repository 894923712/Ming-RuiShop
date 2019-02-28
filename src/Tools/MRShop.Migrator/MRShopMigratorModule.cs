using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MRShop.EntityFramework;

namespace MRShop.Migrator
{
    [DependsOn(typeof(MRShopDataModule))]
    public class MRShopMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MRShopDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}