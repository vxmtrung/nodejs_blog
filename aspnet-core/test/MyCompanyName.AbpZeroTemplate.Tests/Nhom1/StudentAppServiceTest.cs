using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompanyName.AbpZeroTemplate.Nhom1;
using Shouldly;
using Xunit;

namespace MyCompanyName.AbpZeroTemplate.Tests.Nhom1
{
    public class StudentAppServiceTest : AppTestBase
    {
        private readonly IStudentAppService _studentAppService;

        public StudentAppServiceTest()
        {
            _studentAppService = Resolve<IStudentAppService>();

        }

        [Fact]
        public void Should_Get_All_Student_Without_Any_Filter()
        {
            var students = _studentAppService.GetPeople(new Dto.GetStudentInput());

            students.Items.Count.ShouldBe(9);
        }

        [Fact]
        public void Should_Get_Student_With_Name()
        {
            var students = _studentAppService.GetPeople(
                new Dto.GetStudentInput 
            { 
                    Filter = "Bui Phuoc Ban"
            });

            students.Items.Count.ShouldBe(1);
            students.Items[0].Name.ShouldBe("Bui Phuoc Ban");
        }

        [Fact]
        public void Should_Get_Student_With_Id()
        {
            var students = _studentAppService.GetPeople(
                new Dto.GetStudentInput
                {
                    Filter = "2110002"
                });

            students.Items.Count.ShouldBe(1);
            students.Items[0].Name.ShouldBe("Bui Phuoc Ban");
        }

        [Fact]
        public void Should_Get_Student_With_ActivityClass()
        {
            var students = _studentAppService.GetPeople(
                new Dto.GetStudentInput
                {
                    Filter = "PPL"
                });

            students.Items.Count.ShouldBe(2);
            students.Items[0].ActivityClass.ShouldBe("PPL");
            students.Items[1].ActivityClass.ShouldBe("PPL");
        }

        [Fact]
        public void Should_Get_Student_With_UnCompleted_Name()
        {
            var students = _studentAppService.GetPeople(
                new Dto.GetStudentInput
                {
                    Filter = "J"
                });

            students.Items.Count.ShouldBe(2);
            students.Items[0].Name.ShouldBe("John Doe");
            students.Items[1].Name.ShouldBe("Jane Smith");
        }
    }
}
