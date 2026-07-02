using CampusOs.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusOs.Models
{
    public class Exam⁠
    {
        [Key]
        public int ExamsId { get; set; }

        [Required]
        [StringLength(30)]
        public ExamsType ExamsType { get; set; }

        public DateTime ExamsDate { get; set; }

        [StringLength(20)]
        public string RoomNo { get; set; }

        // المادة التابع لها الامتحان
        public string CourseCode { get; set; }
        [ForeignKey("CourseCode")]
        public virtual Course Course { get; set; }
    }
}
