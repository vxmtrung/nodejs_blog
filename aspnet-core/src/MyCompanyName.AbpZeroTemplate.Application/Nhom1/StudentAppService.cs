using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using AutoMapper;
using MyCompanyName.AbpZeroTemplate.Authorization;
using MyCompanyName.AbpZeroTemplate.Dto;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Nhom1
{
    [AbpAuthorize(AppPermissions.Pages_Tenant_Student)]
    public class StudentAppService: AbpZeroTemplateAppServiceBase,IStudentAppService
    {
        private readonly IRepository<Student> _studentRepository;
        public StudentAppService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public ListResultDto<StudentListDto> GetPeople(GetStudentInput input)
        {
            var student= _studentRepository
                .GetAll()
                .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    p => p.StudentId.Contains(input.Filter) ||
                         p.Name.Contains(input.Filter) ||
                         p.ActivityClass.Contains(input.Filter)
                )
                .OrderBy(p => p.StudentId)
                .ThenBy(p => p.Name)
            .ToList();
            return new ListResultDto<StudentListDto>(ObjectMapper.Map<List<StudentListDto>>(student));
        }
    }   
    }
