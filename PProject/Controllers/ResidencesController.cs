using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Residences;

namespace PProject.Controllers
{
    public class ResidencesController : Controller
    {
        #region Members
        private readonly IResidencesService residencesService;

        #endregion Members

        #region Ctor
        public ResidencesController(IResidencesService residencesService)
        {
            this.residencesService = residencesService;
        }
        #endregion Ctor

        public ActionResult Index()
        {
            var viewModel = new ListViewModel<BuildingViewModel>(){Items = new List<BuildingViewModel>()};

            var result = residencesService.GetAllBuildings();

            result.ForEach(u=>viewModel.Items.Add(ViewModelMapper.Mapper.Map<BuildingViewModel>(u)));

            return View(viewModel);
        }
    }
}