using CampusOs.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusOs.Models
{
    public class Applicant⁠
    {
        [Key]
        public int ApplicantsId { get; set; }

        [Required]
        [StringLength(20)]
        public string NationalID { get; set; }

        public decimal HighSchoolScore { get; set; }

        [StringLength(20)]
        public ApplicantState Status { get; set; } = ApplicantState.Pending;
    }
}
