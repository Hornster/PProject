using Desktop.Model.Authorization.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Model.Authorization
{
    /// <summary>
    /// A class that contains information about roles associated with user.
    /// Provides methods to check whether specified action is allowed to be performed by user.
    /// </summary>
    class UserRoles
    {
        /// <summary>
        /// List of rols asociated with user
        /// </summary>
        private List<Role> roles = new List<Role>();
        
        public UserRoles()
        {
            
        }

        public bool Allowed(ActionLevel action)
        {
            if(roles != null)
            {
                foreach(Role rl in roles)
                {
                    if (rl.Allows(action))
                        return true;
                }
            }
            return false;
        }

        public void Add(Role role)
        {
            foreach(Role rl in roles)
            {
                if(rl.Name == role.Name)
                {
                    return;
                }
            }
            roles.Add(role);
        }
    }
}
