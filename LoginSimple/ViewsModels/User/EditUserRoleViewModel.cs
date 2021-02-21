using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginSimple.ViewsModels
{
    public class EditUserRoleViewModel
    {
        public EditUserRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is required.")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
