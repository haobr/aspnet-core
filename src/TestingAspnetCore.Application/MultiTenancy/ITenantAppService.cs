using Abp.Application.Services;
using TestingAspnetCore.MultiTenancy.Dto;

namespace TestingAspnetCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

