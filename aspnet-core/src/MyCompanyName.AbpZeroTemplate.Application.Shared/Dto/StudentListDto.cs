using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.Dto
{
    public class StudentListDto : FullAuditedEntityDto
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string ActivityClass { get; set; }

        public string Group { get ; set; }
    }
}
