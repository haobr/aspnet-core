using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TestingAspnetCore.EntityFrameworkCore
{
    public static class TestingAspnetCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestingAspnetCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestingAspnetCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
