using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.PaymentBills;
using PProject.Models.Payments;

namespace PProject.Controllers
{
    public class PaymentBillsController : Controller
    {
        #region Members
        private readonly IPaymentBillService paymentBillService;

        #endregion Members

        #region Ctor
        public PaymentBillsController(IPaymentBillService paymentBillService)
        {
            this.paymentBillService = paymentBillService;
        }
        #endregion Ctor

        public ActionResult Index(int rentalId)
        {
            var viewModel = new PaymentBillListViewModel() { Items = new List<PaymentBillViewModel>() };
            var result = paymentBillService.GetAllPaymentBills(rentalId);
            viewModel.RentalId = rentalId;
            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<PaymentBillViewModel>(u)));

            return View(viewModel);
        }

        public ActionResult AddPaymentBill(int rentalId)
        {
            var viewModel = new PaymentBillViewModel()
            {
                id_wynajem = rentalId,
                id_faktury = -1       //This is a brand new payment so there's no id.
            };

            return View("EditPaymentBill", viewModel);
        }

        public ActionResult EditPaymentBill(int paymentBillId)
        {
            var viewModel = new PaymentBillViewModel();
            var result = paymentBillService.GetSinglePaymentBillById(paymentBillId);

            viewModel = ViewModelMapper.Mapper.Map<PaymentBillViewModel>(result);
            return View(viewModel);
        }

        public void DeletePaymentBill(int paymentBillId)
        {
            paymentBillService.RemovePaymentBill(paymentBillId);
        }

        public void ConfirmPaymentBillEdit(int rentalId, int paymentBillId, float paymentBillValue, DateTime paymentBillDate, int paymentBillNumber)
        {
            var viewModel = new PaymentBillViewModel()
            {
                id_wynajem = rentalId,
                cena = paymentBillValue,
                data_platnosci = paymentBillDate,
                id_faktury = paymentBillId,
                numer_faktury = paymentBillNumber

            };


            paymentBillService.AddOrEditPaymentBill(ViewModelMapper.Mapper.Map<PaymentBillModel>(viewModel));
        }
        
    }
}