using System;
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
using PProject.Models.Companies;
using PProject.Models.Faults;
using PProject.Models.Repairs;

namespace PProject.Controllers
{
    [Authorize]
    public class RepairsController : Controller
    {
        #region Members
        private readonly IRepairsService repairsService;
        private readonly ICompanyService companyService;

        #endregion Members

        #region Ctor
        public RepairsController(IRepairsService repairsService,
            ICompanyService companyService)
        {
            this.repairsService = repairsService;
            this.companyService = companyService;
        }
        #endregion Ctor
        [AuthorizeRole(AvailableRoles.Treasurer, AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public ActionResult Index(int faultId)
        {
            var viewModel = new RepairListViewModel() { Items = new List<RepairViewModel>() };

            var result = repairsService.GetAllRepairsById(faultId);
            viewModel.FaultId = faultId;

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<RepairViewModel>(u)));

            ViewBag.Errors = TempData["Errors"];
            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public ActionResult AddRepair(int faultId)
        {
            var viewModel = new RepairEditViewModel();
            viewModel.Repair = new RepairViewModel()
            {
                id_usterki = faultId,
                id_naprawy = -1         //It's a new repair so no meaningful index yet.
            };  
            viewModel.CommissionedCompany = new CompanyViewModel()
            {
                id_firmy = -1
            };

            return View("EditRepair", viewModel);
        }
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public ActionResult EditRepair(int repairId)
        {
            var queryResult = repairsService.GetSingleRepairModel(repairId);
            var companyQueryResult = companyService.GetSingleCompany(queryResult.id_firmy);
            var viewModel = new RepairEditViewModel();
            viewModel.Repair = ViewModelMapper.Mapper.Map<RepairViewModel>(queryResult);
            if (companyQueryResult != null)
            {
                viewModel.CommissionedCompany = ViewModelMapper.Mapper.Map <CompanyViewModel> (companyQueryResult);
            }
            else
            {
                viewModel.CommissionedCompany = new CompanyViewModel();
            }

            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public ActionResult DeleteRepair(int faultId, int repairId)
        {
            try
            {
                repairsService.RemoveRepair(repairId);
            }
            catch (Exception e)
            {
                TempData["Errors"] = new[] { e.Message };
            }

            return RedirectToAction("Index", "Repairs", new {faultId = faultId});
        }
        [AuthorizeRole(AvailableRoles.Janitor, AvailableRoles.Administrator)]
        public void ConfirmRepairEdit(int faultId, int repairId, string repairState, DateTime? startDate,
            DateTime? finishDate, DateTime? commissionDate, string companyNip)
        {
            int? companyId = companyService.GetSingleCompany(companyNip)?.id_firmy;
            var newRepair = new RepairViewModel()
            {
                id_usterki = faultId,
                id_firmy = companyId,
                stan = repairState,
                data_rozpoczecia = startDate,
                data_ukonczenia = finishDate,
                data_zlecenia = commissionDate,
                id_naprawy = repairId
            };

            repairsService.AddOrEditRepair(ViewModelMapper.Mapper.Map<RepairModel>(newRepair));
        }
    }
}