﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Common.Enums;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using PProject.App_Start;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Rentals;
using PProject.Models.Residences;

namespace PProject.Controllers
{
    [Authorize]
    public class RentalController : Controller
    {
        #region Members
        private readonly IRentalService rentalService;
        private readonly IResidentsService residentService;
        private readonly IResidencesService residencesService;

        #endregion Members

        #region Ctor
        public RentalController(IRentalService rentalService,
            IResidentsService residentService,
            IResidencesService residencesService)
        {
            this.rentalService = rentalService;
            this.residencesService = residencesService;
            this.residentService = residentService;
        }
        #endregion Ctor
        [AuthorizeRole(AvailableRoles.Overseer, AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult Index()
        {
            var viewModel = new ListViewModel<RentalDataViewModel>() { Items = new List<RentalDataViewModel>() };

            var result = rentalService.GetAllRentals();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<RentalDataViewModel>(u)));

            ViewBag.Errors = TempData["Errors"];
            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Overseer, AvailableRoles.Administrator)]
        public ActionResult AddRental()
        {
            var viewModel = new RentalEditDataViewModel(){RentalId = -1};   //
            return View("EditRental", viewModel);
        }
        [AuthorizeRole(AvailableRoles.Overseer, AvailableRoles.Administrator)]
        public ActionResult EditRental(int rentalId)
        {
            var queryResult = rentalService.GetSingleRentalDataModel(rentalId);
            var assignedResident = residentService.GetSingleResident(queryResult.id_najemcy);
            var assignedResidence =
                residencesService.GetSingleResidenceByID(queryResult.id_budynku, queryResult.id_mieszkania);
            var viewModel = new RentalEditDataViewModel()
            {
                RentalId = rentalId,
                BuildingAddress = queryResult.adres_budynku,
                ExpiringDate = queryResult.data_zakonczenia,
                PESEL = assignedResident.PESEL,
                RentalPrice = queryResult.cena_miesieczna,
                ResidenceNumber = assignedResidence.numer,
                StartDate = queryResult.data_rozpoczecia
            };

            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Overseer, AvailableRoles.Administrator)]
        public ActionResult DeleteRental(int rentalId)
        {
            try
            {
                rentalService.RemoveRental(rentalId);
            }
            catch (Exception e)
            {
                TempData["Errors"] = new[] { e.GetBaseException().Message };
            }

            return RedirectToAction("Index", "Rental");
        }

        [AuthorizeRole(AvailableRoles.Overseer, AvailableRoles.Administrator)]
        public void ConfirmRentalEdit(int rentalId, string residentPESEL, string buildingAddress,
            int residenceNumber, DateTime? startDate, DateTime? expiringDate, float? rentalPrice)
        {
            var residentId = residentService.GetSingleResident(residentPESEL).id_najemcy;
            var building = residencesService.GetSingleBuilding(buildingAddress);
            var residenceId = residencesService.GetSingleResidenceByNumber(building.id_budynku, residenceNumber).id_mieszkania;

            var newRental = new StrictRentalDataViewModel()
            {
                cena_miesieczna = rentalPrice,
                data_rozpoczecia = startDate,
                data_zakonczenia = expiringDate,
                id_mieszkania = residenceId,
                id_najemcy = residentId,
                id_wynajmu = rentalId
            };
            rentalService.AddOrEditRental(ViewModelMapper.Mapper.Map<StrictRentalDataModel>(newRental));
        }
    }
}