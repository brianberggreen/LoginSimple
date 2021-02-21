using Microsoft.AspNetCore.Identity;

namespace LoginSimple.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
