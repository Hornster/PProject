using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Model;
using Desktop.Model.Authorization;

namespace Desktop.Network.Interfaces
{
    /// <summary>
    /// Interface for objects managing database authorization
    /// </summary>
    /// 
    interface IAuthManager
    {
         string SignIn(string serverAddress, string username, string password);
         void SignOut();
    }
}
