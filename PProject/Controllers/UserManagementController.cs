using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthDB.Model.Implementation;
using DB.Services.Interfaces;
using AuthDB.Services.Interfaces;
using DB.Common.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PProject.App_Start;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Faults;
using PProject.Models.UserManagement;

namespace PProject.Controllers
{
    [Authorize]
    public class UserManagementController : Controller
    {
        #region Members
        private readonly IUserService userService;

        #endregion MembersS

        #region Ctor
        public UserManagementController(IUserService userService)
        {
            this.userService = userService;
        }
        #endregion Ctor
        [AuthorizeRole(AvailableRoles.UserManagement, AvailableRoles.Administrator)]
        public ActionResult Index()
        {
            var viewModel = new ListViewModel<UserViewModel>() { Items = new List<UserViewModel>() };

            var result = userService.GetAllUsers();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<UserViewModel>(u)));

            return View(viewModel);
        }
        /// <summary>
        /// Retrieves data for given user editing form.S
        /// </summary>
        /// <returns></returns>
        [AuthorizeRole(AvailableRoles.UserManagement, AvailableRoles.Administrator)]
        public ActionResult EditUser(string userId)
        {
            var queryResult = userService.GetUserById(userId);
            var userRoles = userService.GetUserRoles(queryResult.Id);

            var userViewModel = new List<AvailableRoles>();
            foreach (var role in userRoles)
            {
                AvailableRoles parsedRole;
                if (Enum.TryParse(role.RoleId, out parsedRole))
                {
                    userViewModel.Add(parsedRole);
                }
            }

            var viewModel = new UserEditViewModel();
            viewModel.User = ViewModelMapper.Mapper.Map<UserViewModel>(queryResult);
            viewModel.Roles = userViewModel;

            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.UserManagement, AvailableRoles.Administrator)]
        public void ConfirmEditUser(string userId, string email, string phoneNumber, string[] roles)
        {
            var userModel = new UserModel()
            {
                Id = userId,
                Email = email,
                PhoneNumber = phoneNumber
            };

            var newRoles = new List<RoleModel>();
            if (roles != null)
            {
                foreach (var role in roles)
                {
                    newRoles.Add(new RoleModel()
                    {
                        UserId = userId,
                        RoleId = role
                    });
                }
            }
            
            userService.EditUserBasicData(userModel, newRoles);
        }
        /// <summary>
        /// Deletes user from the database.
        /// </summary>
        /// <param name="userId">RoleId of the user to delete.</param>
        /// <returns></returns>
        [AuthorizeRole(AvailableRoles.UserManagement, AvailableRoles.Administrator)]
        public void DeleteUser(string userId)
        {
            var issuingUserId = User.Identity.GetUserId();
            userService.DeleteUser(issuingUserId, userId);
        }
    }
}