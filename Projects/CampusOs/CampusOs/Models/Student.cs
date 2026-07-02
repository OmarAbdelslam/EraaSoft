using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampusOs.Enums;

namespace CampusOs.Models
{
    public class Student
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; } // هو نفسه UserId لتمثيل علاقة الوراثة (1:1)

        public decimal CGPA { get; set; }

        public int CurrentSemester { get; set; }

        public DateTime EnrollmentDate { get; set; }

        [StringLength(20)]
        public StudentStatus Status { get; set; }

        public int TotalEarnedHours { get; set; }

        // Foreign Key لقسم الطالب
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        // Navigation Properties للعلاقات التانيه
        public virtual Applicant Applicant { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<StudentRequest> StudentRequests { get; set; } = new List<StudentRequest>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<AcademicWarning> AcademicWarnings { get; set; } = new List<AcademicWarning>();
        public virtual ICollection<Enroll> Enrolls { get; set; } = new List<Enroll>();
    }
}
