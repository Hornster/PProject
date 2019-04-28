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
        [HttpGet]
        public ActionResult GetBuildingDetails(int buildingId)
        {
            var viewModel = new BuildingListViewModel(){Items = new List<ResidenceViewModel>()};

            var result = residencesService.GetResidencesById(buildingId);
            result.ForEach(u=>viewModel.Items.Add(ViewModelMapper.Mapper.Map<ResidenceViewModel>(u)));

            return View("BuildingDetails", viewModel);
        }
        [HttpPost]
        public void DeleteResidence(int buildingId, int residenceId)
        {
            residencesService.RemoveResidence(buildingId, residenceId);
        }
        /// <summary>
        /// Can serve both add and edit function. 
        /// </summary>
        /// <param name="buildingId"></param>
        /// <param name="residenceId"></param>
        /// <returns></returns>
        public ActionResult EditResidence(int buildingId, int? residenceId = null)
        {
            var viewModel = new BuildingListViewModel();
            viewModel.Items.Add(new ResidenceViewModel());
            viewModel.BuildingId = buildingId;
            if (residenceId != null)    //If the user edits existing residence - try to retrieve it so they can see its data.
            {
                var result = residencesService.GetSingleResidence(buildingId, (int)residenceId);
                var residence = ViewModelMapper.Mapper.Map<ResidenceViewModel>(result);
                viewModel.Items.Add(residence);
            }

            return View(viewModel);
        }
    }
}