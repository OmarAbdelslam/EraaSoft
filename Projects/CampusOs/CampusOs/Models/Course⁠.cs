using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusOs.Models
{
    public class Course⁠
    {
        [Key]
        [StringLength(20)]
        public string CoursesCode { get; set; }

        [Required]
        [StringLength(150)]
        public string CoursesName { get; set; }

        public int CreditHours { get; set; }

        [StringLength(50)]
        public string CoursesType { get; set; }

        public bool Core { get; set; }
        public bool Elective { get; set; }
        public bool IsOptional { get; set; }
        public bool NonGPACourses { get; set; }
        public int MaxStudents { get; set; }
        

        // Foreign Key للقسم التابع له الكورس
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        // Foreign Key للأستاذ اللي بيدرس المادة
        public int? ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }

        // بتاع جدول الكورسات ناتج عن ريليشن الجدول مع نفسهودا بيتحط فيه كود الماده اللي مينفعش الطالب يفتحها غير لما ينجح في ماده قبلها foregin key دا هو ال 
        public string? RequiredCourseCode { get; set; }
        // علشان ميحصلش تضارب ف الاسماء لان دي ريليشن جدول بنفسه فاكان لازم نغير الاسمNavigation Property  هناغيرنا الاسم   
        // دا العمود اللي هيبقي فيه الماده اللي بتتفتح عادي في جدول الكوسات
        public virtual Course? RequiredCourse { get; set; }

        // Navigation Properties
        public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
        public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<AcademicWarning> AcademicWarnings { get; set; } = new List<AcademicWarning>();
        public virtual ICollection<Enroll> Enrolls { get; set; } = new List<Enroll>();
    }
}
