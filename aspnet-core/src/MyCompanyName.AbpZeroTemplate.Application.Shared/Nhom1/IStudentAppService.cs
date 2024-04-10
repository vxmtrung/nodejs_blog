using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.Nhom1
{
    public interface IStudentAppService
    {
        ListResultDto<StudentListDto> GetPeople(GetStudentInput input);
    }
}
