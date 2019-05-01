using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Faults;
using PProject.Models.Rentals;

namespace PProject.Controllers
{
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

        public ActionResult Index()
        {
            var viewModel = new ListViewModel<FaultDataViewModel>() { Items = new List<FaultDataViewModel>() };

            var result = faultService.GetAllFaultsData();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<FaultDataViewModel>(u)));

            return View(viewModel);
        }
        public ActionResult AddFault()
        {
            var viewModel = new FaultDataViewModel() { id_usterki = -1 };   //
            return View("EditFault", viewModel);
        }

        public ActionResult EditFault(int faultId)
        {
            var queryResult = faultService.GetSingleFaultDataModel(faultId);
            var viewModel = ViewModelMapper.Mapper.Map<FaultDataViewModel>(queryResult);

            return View(viewModel);
        }

        public void DeleteFault(int faultId)
        {
            faultService.RemoveFault(faultId);
        }


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