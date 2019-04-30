using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Rentals;
using PProject.Models.Residences;

namespace PProject.Controllers
{
    public class RentalController : Controller
    {
        #region Members
        private readonly IRentalService rentalService;

        #endregion Members

        #region Ctor
        public RentalController(IRentalService rentalService)
        {
            this.rentalService = rentalService;
        }
        #endregion Ctor

        public ActionResult Index()
        {
            var viewModel = new ListViewModel<RentalDataViewModel>() { Items = new List<RentalDataViewModel>() };

            var result = rentalService.GetAllRentals();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<RentalDataViewModel>(u)));

            return View(viewModel);
        }

        public ActionResult AddRental()
        {
            return View();
        }

        public ActionResult GetRentalDetails(int rentalId)
        {
            var queryResult = rentalService.GetSingleRentalDataModel(rentalId);
            var viewModel = ViewModelMapper.Mapper.Map<RentalDataViewModel>(queryResult);

            return View(viewModel);
        }

        public void DeleteRental(int rentalId)
        {
            rentalService.RemoveRental(rentalId);
        }
    }
}