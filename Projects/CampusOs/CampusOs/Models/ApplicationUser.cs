using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CampusOs.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [StringLength(50)]
        public string LName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedATime { get; set; } = DateTime.Now;

        // Navigation Properties
        public virtual Student Student { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
