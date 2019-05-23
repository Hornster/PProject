using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Common.Enums;

namespace PProject.Models.UserManagement
{
    public class UserEditViewModel
    {
        public UserViewModel User { get; set; }
        public List<AvailableRoles> Roles { get; set; }
    }
}