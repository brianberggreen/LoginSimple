using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LoginSimple.ViewsModels
{
    public class RegisterAccountViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", "Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password dosent match.")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }
    }
}
