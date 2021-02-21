using System.ComponentModel.DataAnnotations;

namespace LoginSimple.ViewsModels
{
    public class CreateUserRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
