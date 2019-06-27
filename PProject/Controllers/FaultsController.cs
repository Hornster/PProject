using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using DB.Common.Enums;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using Microsoft.Ajax.Utilities;
using PProject.App_Start;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Faults;
using PProject.Models.Rentals;

namespace PProject.Controllers
{
    [Authorize]
    public class FaultsController : Controller
    {
        #region Members
        private readonly IFaultService faultService;
        private readonly IResidencesService residencesService;

        #endregion MembersS

        #region Ctor
        public FaultsController(IFaultService faultService,
            IResidencesService residencesService)
        {
            this.faultService = faultService;
            this.residencesService = residencesService;
        }
        #endregion Ctor
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult Index()
        {
            var viewModel = new ListViewModel<FaultDataViewModel>() { Items = new List<FaultDataViewModel>() };

            var result = faultService.GetAllFaultsData();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<FaultDataViewModel>(u)));

            ViewBag.Errors = TempData["Errors"];
            ViewBag.States = string.Join(", ", faultService.GetAllStateNames());
            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public ActionResult AddFault()
        {
            var viewModel = new FaultDataViewModel() { id_usterki = -1 };   //
            return View("EditFault", viewModel);
        }
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public ActionResult EditFault(int faultId)
        {
            var queryResult = faultService.GetSingleFaultDataModel(faultId);
            var viewModel = ViewModelMapper.Mapper.Map<FaultDataViewModel>(queryResult);

            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public ActionResult DeleteFault(int faultId)
        {
            try
            {
                faultService.RemoveFault(faultId);
            }
            catch (Exception e)
            {
                TempData["Errors"] = new[] { e.Message };
            }

            return RedirectToAction("Index", "Faults");
        }

        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public void ConfirmFaultEdit(int faultId, string buildingAddress, int residenceNumber,
            string description, string state)
        {
            var building = residencesService.GetSingleBuilding(buildingAddress);
            var residenceId = residencesService.GetSingleResidenceByNumber(building.id_budynku, residenceNumber).id_mieszkania;

            var newRental = new FaultViewModel()
            {
                id_usterki = faultId,
                id_mieszkania = residenceId,
                opis = description,
                stan = state
            };
            faultService.AddOrEditFault(ViewModelMapper.Mapper.Map<FaultModel>(newRental));
        }
    }
}