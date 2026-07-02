using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampusOs.Enums;

namespace CampusOs.Models
{
    public class StudentRequest⁠
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        [StringLength(50)]
        public StudentRequestType RequestType { get; set; }

        [Required]
        [StringLength(20)]
        public StudentRequestStatus Status { get; set; }

        public DateTime CreatedData { get; set; } = DateTime.Now;

        // Foreign Key للطالب مقدم الطلب
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
