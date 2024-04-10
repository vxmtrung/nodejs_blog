using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Nhom1
{
    [Table("PBStudents")]
    public class Student : FullAuditedEntity<int>
    {
        public const int MaxStudentIdLength = 7;
        public const int MaxNameLength = 100;
        public const int MaxMajorLength = 100;
        public const int MaxStatusLength = 15;
        public const int MaxGroupLength = 20;
        public const int MaxActivityClassLength = 20;

        [Required]
        [StringLength(MaxStudentIdLength)]
        public virtual string StudentId { get; set; }

        [Required]
        [StringLength(MaxNameLength)]
        public virtual string Name { get; set; }

        [StringLength(MaxMajorLength)]
        public virtual string Major { get; set; }

        public virtual int Batch { get; set; } = 15;

        [StringLength(MaxStatusLength)]
        public virtual string Status { get; set; } = "Đang học";

        [StringLength(MaxGroupLength)]
        public virtual string Group { get; set; }

        [StringLength(MaxActivityClassLength)]
        public virtual string ActivityClass { get; set; }
    }

}
