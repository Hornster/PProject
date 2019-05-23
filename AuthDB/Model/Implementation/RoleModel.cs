using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthDB.Model.Interfaces;

namespace AuthDB.Model.Implementation
{
    public class RoleModel : IRoleModel
    {
        public string RoleId { get; set; }
        public string UserId { get; set; }
    }
}
