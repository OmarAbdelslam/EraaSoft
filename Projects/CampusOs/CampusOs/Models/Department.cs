using System.ComponentModel.DataAnnotations;

namespace CampusOs.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }

        // Navigation Properties
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
        public virtual ICollection<Professor> Professors { get; set; } = new List<Professor>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
