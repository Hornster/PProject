using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Services.Interfaces;
using AuthDB.Services.Interfaces;
using DB.Common.Enums;
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
        [AuthorizeRole(AvailableRoles.UserManagement, AvailableRoles.Administrator)]
        public ActionResult EditUser()
        {
            throw new NotImplementedException();
        }
        [AuthorizeRole(AvailableRoles.UserManagement, AvailableRoles.Administrator)]
        public ActionResult DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}