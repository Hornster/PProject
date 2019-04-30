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
            var viewModel = new BuildingListViewModel()
            {
                Items = new List<ResidenceViewModel>(),
                Building =  new BuildingViewModel()
            };
            viewModel.Building.id_budynku = buildingId;

            var result = residencesService.GetResidencesById(buildingId);
            result.ForEach(u=>viewModel.Items.Add(ViewModelMapper.Mapper.Map<ResidenceViewModel>(u)));

            var buildingResult = residencesService.GetSingleBuilding(buildingId);
            viewModel.Building.adres_budynku = buildingResult.adres_budynku;

            return View("BuildingDetails", viewModel);
        }
        [HttpPost]
        public void DeleteResidence(int buildingId, int residenceId)
        {
            residencesService.RemoveResidence(buildingId, residenceId);
        }

        [HttpPost]
        public void DeleteBuilding(int buildingId)
        {
            residencesService.RemoveBuilding(buildingId);
        }
        /// <summary>
        /// Returns residence edit form. Can serve both add and edit function. 
        /// </summary>
        /// <param name="buildingId"></param>
        /// <param name="residenceId"></param>
        /// <returns></returns>
        public ActionResult EditResidence(int buildingId, int? residenceId = null)
        {
            var viewModel = new BuildingListViewModel()
            {
                Items = new List<ResidenceViewModel>(),
                Building = new BuildingViewModel()
            };
            viewModel.Building.id_budynku = buildingId;
            if (residenceId != null)    //If the user edits existing residence - try to retrieve it so they can see its data.
            {
                var result = residencesService.GetSingleResidenceByID(buildingId, (int)residenceId);
                var residence = ViewModelMapper.Mapper.Map<ResidenceViewModel>(result);
                viewModel.Items.Add(residence);
            }
            else
            {
                viewModel.Items.Add(new ResidenceViewModel());
                viewModel.Items[0].id_mieszkania = -1;  //This residence does not exist, it's just a placeholder.
            }

            return View(viewModel);
        }

        /// <summary>
        /// Returns building edit form. Can serve both add and edit function. 
        /// </summary>
        /// <param name="buildingId"></param>
        /// <param name="residenceId"></param>
        /// <returns></returns>
        public ActionResult EditBuilding(int? buildingId)
        {
            var viewModel = new BuildingViewModel();
            if (buildingId != null)    //If the user edits existing residence - try to retrieve it so they can see its data.
            {
                var result = residencesService.GetSingleBuilding((int)buildingId);
                viewModel = ViewModelMapper.Mapper.Map<BuildingViewModel>(result);
            }
            else
            {
                viewModel = new BuildingViewModel();
                viewModel.id_budynku = -1;  //This residence does not exist, it's just a placeholder.
            }

            return View(viewModel);
        }
        /// <summary>
        /// Prepares model object for processing for the database and service.
        /// </summary>
        /// <param name="buildingId"></param>
        /// <param name="residenceId"></param>
        /// <param name="residenceNumber"></param>
        /// <param name="residenceSurface"></param>
        /// <param name="residenceDescription"></param>
        [HttpPost]
        public void ConfirmResidenceChange(int buildingId, int residenceId, int residenceNumber, float residenceSurface, string residenceDescription)
        {
            var residence = new ResidenceViewModel();
            residence.id_budynku = buildingId;
            residence.id_mieszkania = residenceId;
            residence.numer = residenceNumber;
            residence.metraz = residenceSurface;
            residence.opis = residenceDescription;

            var residenceModel = ViewModelMapper.Mapper.Map<ResidenceModel>(residence);

            residencesService.AddOrEditResidence(residenceModel);
        }
        /// <summary>
        /// Prepares model object for processing for the database and service.
        /// </summary>
        /// <param name="buildingId"></param>
        /// <param name="address"></param>
        [HttpPost]
        public void ConfirmBuildingChange(int buildingId, string address)
        {
            var building = new BuildingViewModel();
            building.id_budynku = buildingId;
            building.adres_budynku = address;

            var buildingModel = ViewModelMapper.Mapper.Map<BuildingModel>(building);

            residencesService.AddOrEditBuilding(buildingModel);
        }
    }
}