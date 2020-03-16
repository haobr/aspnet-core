using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using TestingAspnetCore.Authors.Dto;
using Microsoft.EntityFrameworkCore;

namespace TestingAspnetCore.Authors
{
    public class AuthorAppService : TestingAspnetCoreAppServiceBase, IAuthorAppService
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorAppService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<ListResultDto<AuthorListDto>> GetListAuthor(AuthorInput input)
        {
            var listAuthor = await _authorRepository.GetAll()
                .WhereIf(input.Filter != null, t => t.FirstName.Contains(input.Filter) || t.LastName.Contains(input.Filter)) 
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<AuthorListDto>(
                ObjectMapper.Map<List<AuthorListDto>>(listAuthor));
        }
    }
}
