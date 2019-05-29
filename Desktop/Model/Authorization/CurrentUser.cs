using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Model.Authorization;

namespace Desktop.Model
{
    /// <summary>
    /// Class that contains data of currently logged used.
    /// Contains:
    /// user data
    /// connection id
    /// </summary>
    class CurrentUser
    {

        private static CurrentUser instance = null;

        /// <summary>
        /// User data
        /// </summary>
        public UserData Data { get; set; }

        /// <summary>
        /// User role info
        /// </summary>
        public UserRoles Roles { get; set; }

        /// <summary>
        /// Connection id associated with currently logged user
        /// </summary>
        public int? ConnectionID { get; set; }

        

        /// <summary>
        /// Private constructor
        /// </summary>
        private CurrentUser()
        {
            Data = null;
            Roles = null;
            ConnectionID = null;   
        }

        /// <summary>
        /// Retrieves refernce to CurrentUser object. Creates new instance if object doesn't exist
        /// </summary>
        /// <returns>Object instance</returns>
        public static CurrentUser GetInstance()
        {
            if (instance == null)
                instance = new CurrentUser();
            return instance;
        }

    }
}
