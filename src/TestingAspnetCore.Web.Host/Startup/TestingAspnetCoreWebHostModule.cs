using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestingAspnetCore.Configuration;

namespace TestingAspnetCore.Web.Host.Startup
{
    [DependsOn(
       typeof(TestingAspnetCoreWebCoreModule))]
    public class TestingAspnetCoreWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestingAspnetCoreWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestingAspnetCoreWebHostModule).GetAssembly());
        }
    }
}
