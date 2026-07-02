using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusOs.Models
{
    public class Enroll
    {  // Composite Key بيتم تعريفها في الـ DbContext (طالب + مادة + ترم)
        public int StudentId { get; set; }
        public string CourseCode { get; set; }
        public string SemesterTaken { get; set; }
        public decimal GradePoints { get; set; }

        [StringLength(5)]
        public string LetterGrade { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("CourseCode")]
        public virtual Course Course { get; set; }
    }
}
