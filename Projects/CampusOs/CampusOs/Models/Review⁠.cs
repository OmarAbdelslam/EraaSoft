using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusOs.Models
{
        public class Review
        {
            [Key]
            public int ReviewId { get; set; }

            public int Rating { get; set; } // من 1 لـ 5

            public string Comment { get; set; }

            // كاتب التقييم والمادة المقصودة
            public int StudentId { get; set; }
            [ForeignKey("StudentId")]
            public virtual Student Student { get; set; }

            public string CourseCode { get; set; }
            [ForeignKey("CourseCode")]
            public virtual Course Course { get; set; }
        }
}
