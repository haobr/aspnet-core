using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingAspnetCore.Authors
{
    [Table("Author")]
    public class Author : Entity, IHasCreationTime
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
