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

            var student3 = _context.Students.FirstOrDefault(p => p.StudentId == "2110002");
            if (student3 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110002",
                        Name = "Bui Phuoc Ban",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "B",
                        ActivityClass = "QLDAPM",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }

            var student4 = _context.Students.FirstOrDefault(p => p.StudentId == "2110003");
            if (student4 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110003",
                        Name = "Vo Ngoc Thanh Nhan",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "A",
                        ActivityClass = "QLDAPM",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }

            var student5 = _context.Students.FirstOrDefault(p => p.StudentId == "2110004");
            if (student5 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110004",
                        Name = "Le Nguyen Chuong",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "A",
                        ActivityClass = "QLDAPM",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }

            var student6 = _context.Students.FirstOrDefault(p => p.StudentId == "2110005");
            if (student6 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110005",
                        Name = "Truong Thuan Hung",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "B",
                        ActivityClass = "QLDAPM",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }

            var student7 = _context.Students.FirstOrDefault(p => p.StudentId == "2110006");
            if (student7 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110006",
                        Name = "Nguyen Minh Diem",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "A",
                        ActivityClass = "QLDAPM",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }

            var student8 = _context.Students.FirstOrDefault(p => p.StudentId == "2110007");
            if (student8 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110007",
                        Name = "Thai Ngoc Rang",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "B",
                        ActivityClass = "QLDAPM",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }

            var student9 = _context.Students.FirstOrDefault(p => p.StudentId == "2110008");
            if (student9 == null)
            {
                _context.Students.Add(
                    new Student
                    {
                        StudentId = "2110008",
                        Name = "Vu Xuan Mai Trung",
                        Major = "Computer Science",
                        Batch = 2021,
                        Status = "Active",
                        Group = "A",
                        ActivityClass = "QLDAPM",
                        CreationTime = DateTime.Now,
                        IsDeleted = false
                    });
            }

        }
    }
}
