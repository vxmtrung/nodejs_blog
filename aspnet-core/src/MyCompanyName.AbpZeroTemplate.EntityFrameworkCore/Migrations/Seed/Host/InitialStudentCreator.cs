using MyCompanyName.AbpZeroTemplate.EntityFrameworkCore;
using MyCompanyName.AbpZeroTemplate.Nhom1;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Migrations.Seed.Host
{
    public class InitialStudentCreator
    {
        private readonly AbpZeroTemplateDbContext _context;

        public InitialStudentCreator(AbpZeroTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var student1 = _context.Students.FirstOrDefault(p => p.StudentId == "2110000");
            if (student1 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110000",
                        Name = "John Doe",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "A",
                        ActivityClass = "PPL",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }
            var student2 = _context.Students.FirstOrDefault(p => p.StudentId == "2110001");
            if (student2 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110001",
                        Name = "Jane Smith",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "A",
                        ActivityClass = "PPL",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }
        }
    }
}
