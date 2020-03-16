using Abp.Application.Services.Dto;

namespace TestingAspnetCore.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

