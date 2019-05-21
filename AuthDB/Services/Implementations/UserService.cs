using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthDB.Mappers;
using AuthDB.Model.Implementation;
using AuthDB.Services.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthDB.Services.Implementations
{
    public class UserService : IUserService
    {
        public UserModel GetUserById(string userId)
        {
            UserModel user = null;
            var appUser = new ApplicationUser();
            try
            {
                using (var ctx = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
                {
                    var query = ctx.Users.FirstOrDefault(x => x.Id == userId);
                    
                    user = AuthModelMapper.Mapper.Map<UserModel>(query); //Select first user of provided ID
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return user;
        }

        public List<UserModel> GetAllUsers()
        {
            var users = new List<UserModel>();

            try
            {
                using (var ctx = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
                {
                    var results = ctx.Users.Select(x => x);
                    foreach (var user in results)
                    {
                        users.Add(AuthModelMapper.Mapper.Map<UserModel>(user));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return users;
        }

        public List<RoleModel> GetUserRoles(string userId)
        {
            var result = new List<RoleModel>();

            try
            {
                using (var ctx = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
                {
                    var userRoles = ctx.Users.FirstOrDefault(x => x.Id == userId)?.Roles;
                    
                    if (userRoles != null)
                    {
                        foreach (var role in userRoles)
                        {
                            result.Add(AuthModelMapper.Mapper.Map<RoleModel>(role));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public void EditUserBasicData(UserModel user, List<RoleModel> newRoles)
        {
            try
            {
                using (var ctx = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
                {
                    var editedUser = ctx.Users.First(x => x.Id == user.Id);

                    if (editedUser != null)
                    {
                        var userRoles = GetUserRolesNames(editedUser).ToArray();
                        
                        var result = ctx.RemoveFromRoles(editedUser.Id, userRoles);

                        if (!result.Succeeded)
                        {
                            throw new Exception(result.ToString());
                        }
                        
                        var newUserRoles = GetUserRolesNames(newRoles).ToArray();
                        result = ctx.AddToRoles(editedUser.Id, newUserRoles);

                        if (!result.Succeeded)
                        {
                            throw new Exception(result.ToString());
                        }

                        editedUser.Email = user.Email;
                        editedUser.PhoneNumber = user.PhoneNumber;

                        ctx.SetEmail(editedUser.Id, user.Email);
                        ctx.SetPhoneNumber(editedUser.Id, user.PhoneNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteUser(string issuingUserId, string userId)
        {
            if (issuingUserId.Equals(userId))
            {
                return; //User cannot delete themselves.
            }
            try
            {
                using (var ctx = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
                {
                    var user = ctx.Users.FirstOrDefault(x => x.Id == userId);
                    var result = ctx.Delete(user);

                    if (!result.Succeeded)
                    {
                        throw new Exception(result.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves roles assigned to provided user.
        /// </summary>
        /// <param name="user">User from whose roles shall be retrieved.</param>
        /// <returns></returns>
        private List<string> GetUserRolesNames(ApplicationUser user)
        {
            var roles = new List<string>();
            foreach (var identityUserRole in user.Roles)
            {
                roles.Add(identityUserRole.RoleId);
            }

            return roles;
        }

        private List<string> GetUserRolesNames(List<RoleModel> roles)
        {
            var rolesNames = new List<string>();
            foreach (var role in roles)
            {
                rolesNames.Add(role.Name);
            }

            return rolesNames;
        }

    }
}
//When user modifies another user, list of present during modifications roles is sent.
//Upon receiving the data from db, the roles for the user are cleared and the passed ones are
//assigned instead. This way, if and role was deleted - it will be deleted from the user, any added
//role will be added and not touched roles will stay untouched.