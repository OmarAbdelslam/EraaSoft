using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampusOs.Enums;

namespace CampusOs.Models
{
    public class Payment⁠
    {
        [Key]
        public int PaymentId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(30)]
        public PaymentMethods PaymentsMethod { get; set; }

        [StringLength(20)]
        public StatusPayment Status { get; set; }

        [Required]
        [StringLength(100)]
        public string TransactionReference { get; set; }

        // Foreign Key للطالب المسدد
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}

