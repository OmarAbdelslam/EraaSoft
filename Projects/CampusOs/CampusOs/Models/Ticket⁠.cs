using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampusOs.Enums;

namespace CampusOs.Models
{
    public class Ticket⁠
    {
        [Key]
        public int TicketsId { get; set; }

        [Required]
        [StringLength(150)]
        public string Subject { get; set; }

        [Required]
        public string Description { get; set; }

        [StringLength(20)]
        public TicketPriority Priority { get; set; }

        [StringLength(20)]
        public TicketStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // المستخدم منشئ التذكرة (طالب أو دكتور)
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
