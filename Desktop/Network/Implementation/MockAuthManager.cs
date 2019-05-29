using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Model;
using Desktop.Model.Authorization;
using Desktop.Model.Authorization.Enums;
using Desktop.Network.Interfaces;

namespace Desktop.Network.Implementation
{
    class MockAuthManager : IAuthManager
    {

        public string SignIn(string serverAddress, string username, string password)
        {
            //Allows only localhost server 
            if (serverAddress != "localhost")
                return "Unable to connect to server";

            UserData userData = new UserData();
            UserRoles userRoles = new UserRoles();
            CurrentUser currentUser = CurrentUser.GetInstance();
            //If admin
            if (username == "admin" && password == "admin")
            {
                userData.Email = "iamtheboss@admin.com";
                userData.PhoneNumber = "999999999";
                userData.Name = "Hugo";
                userData.Surname = "Boss";
                userData.Login = username;
                userRoles.Add(new Role("Master of everything", ActionLevel.AdminAction));
                currentUser.ConnectionID = 1;
                currentUser.Data = userData;
                currentUser.Roles = userRoles;
                return null ;
            }
            return "Wrong username or password";
        }

        public void SignOut()
        {
            
        }
    }
}
