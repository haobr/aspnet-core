using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingAspnetCore.Authors.Dto
{
    [AutoMapFrom(typeof(Author))]
    public class AuthorListDto : EntityDto, IHasCreationTime
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
