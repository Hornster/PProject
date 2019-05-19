using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthDB.Mappers;
using AuthDB.Model.Implementation;

namespace AuthDB.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Returns user of provided ID, or null if not found.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        UserModel GetUserById(string userId);
        /// <summary>
        /// Returns all users.
        /// </summary>
        /// <returns></returns>
        List<UserModel> GetAllUsers();
        /// <summary>
        /// Edits provided users name, email, phone number and roles.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newRoles"></param>
        void EditUserBasicData(UserModel user, List<RoleModel> newRoles);
    }
}
