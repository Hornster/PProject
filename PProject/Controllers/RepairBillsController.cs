using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models.Companies;
using PProject.Models.RepairBills;
using PProject.Models.Repairs;

namespace PProject.Controllers
{
    [Authorize]
    public class RepairBillsController : Controller
    {
        #region Members
        private readonly IRepairBillService repairBillService;
        private readonly IRepairsService repairService;

        #endregion Members

        #region Ctor
        public RepairBillsController(IRepairBillService repairBillService,
            IRepairsService repairService)
        {
            this.repairBillService = repairBillService;
            this.repairService = repairService;
        }
        #endregion Ctor

        public ActionResult Index(int repairId)
        {
            var viewModel = new RepairBillListViewModel() { Items = new List<RepairBillViewModel>() };

            var result = repairBillService.GetAllRepairBillsById(repairId);
            viewModel.RepairId = repairId;

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<RepairBillViewModel>(u)));

            return View(viewModel);
        }

        public ActionResult AddRepairBill(int repairId)
        {
            var viewModel = new RepairBillViewModel()
            {
                id_naprawy = repairId,
                id_faktury = -1//It's a new repair bill so no meaningful index yet.
            };

            return View("EditRepairBill", viewModel);
        }

        public ActionResult EditRepairBill(int repairBillId)
        {
            var queryResult = repairBillService.GetSingleRepairBillModel(repairBillId);
            var viewModel = ViewModelMapper.Mapper.Map<RepairBillViewModel>(queryResult);
            
            return View(viewModel);
        }

        public void DeleteRepairBill(int repairBillId)
        {
            repairBillService.RemoveRepairBill(repairBillId);
        }

        public void ConfirmRepairBillEdit(int repairBillId, int repairId, int billNumber, float billPayment, DateTime? billDate)
        {
            var newRepairBill = new RepairBillViewModel()
            {
                id_naprawy = repairId,
                id_faktury = repairBillId,
                cena = billPayment,
                data_platnosci = billDate,
                numer_faktury = billNumber
            };

            repairBillService.AddOrEditRepairBill(ViewModelMapper.Mapper.Map<RepairBillModel>(newRepairBill));
        }

        public ActionResult BackToRepairsTable(int repairId)
        {
            var queryResult = repairService.GetSingleRepairModel(repairId);
            int? repairFaultId = queryResult.id_usterki;

            if (repairFaultId != null)
            {
                return RedirectToAction("Index", "Repairs", new{faultId = repairFaultId});
            }
            else
            {
                return View("CouldNotFindFault");
            }
        }
    }
}