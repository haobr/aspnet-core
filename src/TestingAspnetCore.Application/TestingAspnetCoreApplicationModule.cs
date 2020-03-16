using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestingAspnetCore.Authorization;

namespace TestingAspnetCore
{
    [DependsOn(
        typeof(TestingAspnetCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestingAspnetCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestingAspnetCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestingAspnetCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
