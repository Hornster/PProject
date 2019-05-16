using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Residents;

namespace PProject.Controllers
{
    [Authorize]
    public class ResidentsController : Controller
    {
        #region Members
        private readonly IResidentsService residentsService;

        #endregion Members

        #region Ctor
        public ResidentsController(IResidentsService residentsService)
        {
            this.residentsService = residentsService;
        }
        #endregion Ctor


        #region ActionMethods
        public ActionResult Index()
        {
            var viewModel = new ListViewModel<ResidentViewModel>() { Items = new List<ResidentViewModel>() };
            //Retrieve all residents.

            var result = residentsService.GetAllResidents();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<ResidentViewModel>(u)));

            return View(viewModel);
        }



        #endregion ActionMethods
        /// <summary>
        /// Called to provide user edit form.
        /// </summary>
        /// <param name="residentId">ID of resident that will be edited.</param>
        /// <returns></returns>
        public ActionResult EditResident(int? residentId)
        {
            ResidentViewModel viewModel = null;

            if (residentId != null)
            {
                var queryResult = residentsService.GetSingleResident((int)residentId);
                viewModel = ViewModelMapper.Mapper.Map<ResidentViewModel>(queryResult);
            }
            else
            {
                viewModel = new ResidentViewModel();
                viewModel.id_najemcy = -1;
            }

            return View(viewModel);
        }
        /// <summary>
        /// Accepts data from resident edit form
        /// </summary>
        /// <param name="residentId"></param>
        /// <param name="residentName"></param>
        /// <param name="residentSurname"></param>
        /// <param name="residentPhone"></param>
        /// <param name="residentPESEL"></param>
        public void ConfirmResidentChange(int residentId, string residentName, string residentSurname, string residentPhone, string residentPESEL)
        {
            var newResident = new ResidentViewModel()
            {
                id_najemcy = residentId,
                imie = residentName,
                nazwisko = residentSurname,
                nr_telefonu = residentPhone,
                PESEL = residentPESEL
            };

            var preparedResident = ViewModelMapper.Mapper.Map<ResidentModel>(newResident);

            residentsService.AddOrEditResident(preparedResident);
        }
    }
}