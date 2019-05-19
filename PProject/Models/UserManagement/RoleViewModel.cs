using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthDB.Model.Interfaces;

namespace PProject.Models.UserManagement
{
    public class RoleViewModel : IRoleModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}