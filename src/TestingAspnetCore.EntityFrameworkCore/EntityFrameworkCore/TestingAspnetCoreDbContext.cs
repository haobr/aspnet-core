using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestingAspnetCore.Authorization.Roles;
using TestingAspnetCore.Authorization.Users;
using TestingAspnetCore.MultiTenancy;
using TestingAspnetCore.Authors;

namespace TestingAspnetCore.EntityFrameworkCore
{
    public class TestingAspnetCoreDbContext : AbpZeroDbContext<Tenant, Role, User, TestingAspnetCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Author> Authors { get; set; }
        
        public TestingAspnetCoreDbContext(DbContextOptions<TestingAspnetCoreDbContext> options)
            : base(options)
        {
        }
    }
}
