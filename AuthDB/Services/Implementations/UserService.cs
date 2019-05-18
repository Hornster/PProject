using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthDB.Mappers;
using AuthDB.Model.Implementation;
using AuthDB.Services.Interfaces;

namespace AuthDB.Services.Implementations
{
    public class UserService : IUserService
    {
        public UserModel GetUserById(string userId)
        {
            UserModel user = null;

            try
            {
                using (var ctx = new Entities())
                {
                    var results = ctx.AspNetUsers.First(x => x.Id == userId);
                    
                    user = AuthModelMapper.Mapper.Map<UserModel>(user);
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
                using (var ctx = new Entities())
                {
                    var results = ctx.AspNetUsers.Select(x => x);
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

        public void EditUser(UserModel user, List<RoleModel> newRoles)
        {
            try
            {
                using (var ctx = new Entities())
                {
                    var editedUser = ctx.AspNetUsers.First(x => x.Id == user.Id);

                    if (editedUser != null)
                    {
                        editedUser.AspNetRoles.Clear();

                        foreach (var newRole in newRoles)
                        {
                            editedUser.AspNetRoles.Add(AuthModelMapper.Mapper.Map<AspNetRoles>(newRole));
                        }

                        editedUser.Email = user.Email;
                        editedUser.PhoneNumber = user.PhoneNumber;
                        editedUser.UserName = user.UserName;
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
//When user modifies another user, list of present during modifications roles is sent.
//Upon receiving the data from db, the roles for the user are cleared and the passed ones are
//assigned instead. This way, if and role was deleted - it will be deleted from the user, any added
//role will be added and not touched roles will stay untouched.