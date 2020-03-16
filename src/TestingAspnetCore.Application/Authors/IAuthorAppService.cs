using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using TestingAspnetCore.Authors.Dto;

namespace TestingAspnetCore.Authors
{
    public interface IAuthorAppService : IApplicationService
    {
        Task<ListResultDto<AuthorListDto>> GetListAuthor(AuthorInput input);
    }
}
