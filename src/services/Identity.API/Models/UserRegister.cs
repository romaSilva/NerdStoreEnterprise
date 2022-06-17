using System.ComponentModel.DataAnnotations;

namespace Identity.API.Models
{
    public class UserRegister
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmationPassword { get; set; }
    }
}
