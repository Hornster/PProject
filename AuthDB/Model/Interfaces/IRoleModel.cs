using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthDB.Model.Interfaces
{
    public interface IRoleModel
    {
        string RoleId { get; set; }
        string UserId { get; set; }
    }
}
