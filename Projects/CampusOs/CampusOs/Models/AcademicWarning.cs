using Microsoft.EntityFrameworkCore.Update;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampusOs.Enums;

namespace CampusOs.Models
{
    public class AcademicWarning
    {
        [Key]
        public int WarningsId { get; set; }

        [Required]
        [StringLength(50)]
        public WarningAcademy WarningsLevel { get; set; }

        public DateTime DateIssued { get; set; } = DateTime.Now;

        // الطالب الموجه له الإنذار والمادة المتسببة إن وُجدت
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public string CourseCode { get; set; }
        [ForeignKey("CourseCode")]
        public virtual Course Course { get; set; }
    }
}
