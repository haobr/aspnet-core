using System.Threading.Tasks;
using Abp.Application.Services;
using TestingAspnetCore.Sessions.Dto;

namespace TestingAspnetCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
