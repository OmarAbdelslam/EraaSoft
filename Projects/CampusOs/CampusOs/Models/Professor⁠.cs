using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampusOs.Enums;

namespace CampusOs.Models
{
    public class Professor⁠
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; } // هو نفسه UserId لتمثيل علاقة الوراثة (1:1)

        [Required]
        [StringLength(50)]
        public ProfessorScientificDegree ScientificDegree { get; set; }

        public DateTime HiringDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        // Foreign Key للقسم اللي شغال فيه الدكتور
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        // Navigation Properties
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; } = new List<Announcement>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
