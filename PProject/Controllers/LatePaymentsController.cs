using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Common.Enums;
using DB.Model.Interfaces;
using DB.Services.Interfaces;
using PProject.App_Start;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Residents;

namespace PProject.Controllers
{
    [Authorize]
    public class LatePaymentsController : Controller
    {
        #region Members
        private readonly ILatePaymentService service;

        #endregion Members

        #region Ctor
        public LatePaymentsController(ILatePaymentService service)
        {
            this.service = service;
        }
        #endregion Ctor

        #region ActionMethods
        [AuthorizeRole(AvailableRoles.Overseer, AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult Index()
        {
            var viewModel = new ListViewModel<ILatePaymentModel>() { Items = new List<ILatePaymentModel>() };
            //Retrieve all residents.

            var result = service.GetAllLatePayments();

            result.ToList().ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<ILatePaymentModel>(u)));

            return View(viewModel);
        }
        #endregion  
    }
}