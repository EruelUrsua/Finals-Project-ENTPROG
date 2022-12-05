using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.App.Models
{
    public class PatientVM
    {
        [Key]
        public int PatientID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Name should be 2 to 50 characters only.")]
        [DisplayName("Lastname")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Name should be 2 to 50 characters only.")]
        [DisplayName("Firstname")]
        public string Firstname { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Address should be 2 to 50 characters only.")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11,
            ErrorMessage = "Contact Number should be standard 11 digits")]
        public string ContactNumber { get; set; }

        [Required]
        public string Brand { get; set; }
    }
}
