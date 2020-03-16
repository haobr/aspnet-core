using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestingAspnetCore.Configuration;
using TestingAspnetCore.EntityFrameworkCore;
using TestingAspnetCore.Migrator.DependencyInjection;

namespace TestingAspnetCore.Migrator
{
    [DependsOn(typeof(TestingAspnetCoreEntityFrameworkModule))]
    public class TestingAspnetCoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TestingAspnetCoreMigratorModule(TestingAspnetCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(TestingAspnetCoreMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                TestingAspnetCoreConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestingAspnetCoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
