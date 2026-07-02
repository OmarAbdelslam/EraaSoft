using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampusOs.Enums;

namespace CampusOs.Models
{
    public class Attendance⁠
    {
        [Key]
        public int AttendanceId { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;

        public int LectureNo { get; set; } // رقم المحاضرة (مثلاً: المحاضرة الأولى، الثان

        // حالة المحاضرة: Active (قائمة), Cancelled (ملغاة), Postponed (مؤجلة)
        [Required]
        [StringLength(20)]
        public LectureState LectureStatus { get; set; } = LectureState.Scheduled;

        // سبب الإلغاء إن وُجد (مثل: عذر صحي للدكتور)
        [StringLength(250)]
        public string CancellationReason { get; set; } 

        public bool IsPresent { get; set; } // هتبقى false لو المحاضرة اتلغت تلقائياً

        // ربط السجل بالطالب والمادة
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public string CourseCode { get; set; }
        [ForeignKey("CourseCode")]
        public virtual Course Course { get; set; }
    }
}
