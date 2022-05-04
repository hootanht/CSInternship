using System.ComponentModel.DataAnnotations;

namespace TwitchStep02.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(150)]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter customer's email address")]
        [StringLength(150)]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter customer's phone number")]
        [StringLength(150)]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter customer's salary amount")]
        [Display(Name = "Salary (in $)")]
        public decimal Salary { get; set; }
    }
}
