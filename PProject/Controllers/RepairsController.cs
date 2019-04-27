using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Repairs;

namespace PProject.Controllers
{
    public class RepairsController : Controller
    {
        #region Members
        private readonly IRepairsService repairsService;

        #endregion Members

        #region Ctor
        public RepairsController(IRepairsService repairsService)
        {
            this.repairsService = repairsService;
        }
        #endregion Ctor

        public ActionResult Index()
        {
            var viewModel = new ListViewModel<RepairViewModel>() { Items = new List<RepairViewModel>() };

            var result = repairsService.GetAllRepairs();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<RepairViewModel>(u)));

            return View(viewModel);
        }
    }
}