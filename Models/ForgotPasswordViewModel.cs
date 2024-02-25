using System.ComponentModel.DataAnnotations;

namespace Authorization.Models
{
    public class ForgotPasswordViewModel
    {
        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
