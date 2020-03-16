using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestingAspnetCore.Configuration;
using TestingAspnetCore.Web;

namespace TestingAspnetCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestingAspnetCoreDbContextFactory : IDesignTimeDbContextFactory<TestingAspnetCoreDbContext>
    {
        public TestingAspnetCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestingAspnetCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestingAspnetCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestingAspnetCoreConsts.ConnectionStringName));

            return new TestingAspnetCoreDbContext(builder.Options);
        }
    }
}
