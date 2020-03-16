using System.Threading.Tasks;
using Abp.Application.Services;
using TestingAspnetCore.Authorization.Accounts.Dto;

namespace TestingAspnetCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
