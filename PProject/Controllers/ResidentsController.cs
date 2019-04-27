using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Residents;

namespace PProject.Controllers
{
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
    }
}