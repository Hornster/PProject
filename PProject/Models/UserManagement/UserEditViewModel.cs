using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PProject.Models.UserManagement
{
    public class UserEditViewModel
    {
        public UserViewModel User { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}