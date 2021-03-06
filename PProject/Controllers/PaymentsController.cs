﻿using System;
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
using PProject.Models.Payments;

namespace PProject.Controllers
{
    [Authorize]
    public class PaymentsController : Controller
    {
        #region Members
        private readonly IPaymentService paymentService;

        #endregion Members

        #region Ctor
        public PaymentsController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        #endregion Ctor
        [AuthorizeRole(AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult Index(int rentalId)
        {
            var viewModel = new PaymentListViewModel() { Items = new List<PaymentViewModel>()};
            var result = paymentService.GetAllPayments(rentalId);
            viewModel.RentalId = rentalId;
            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<PaymentViewModel>(u)));

            ViewBag.Errors = TempData["Errors"];
            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult AddPayment(int rentalId)
        {
            var viewModel = new PaymentViewModel()
            {
                id_wynajmu = rentalId,
                id_platnosci = -1       //This is a brand new payment so there's no id.
            };

            return View("EditPayment", viewModel);
        }
        [AuthorizeRole(AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult EditPayment(int paymentId)
        {
            var viewModel = new PaymentViewModel();
            var result = paymentService.GetSinglePaymentById(paymentId);

            viewModel = ViewModelMapper.Mapper.Map<PaymentViewModel>(result);
            return View(viewModel);
        }
        [AuthorizeRole(AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult DeletePayment(int rentalId, int paymentId)
        {
            try
            {
                paymentService.RemovePayment(paymentId);
            }
            catch (Exception e)
            {
                TempData["Errors"] = new[] { e.Message };
            }

            return RedirectToAction("Index", "Payments", new {rentalId = rentalId });

        }
        [AuthorizeRole(AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public void ConfirmPaymentEdit(int rentalId, int paymentId, float paymentValue, DateTime paymentDate, string paymentTitle)
        {
            var viewModel = new PaymentViewModel()
            {
                id_wynajmu = rentalId,
                cena = paymentValue,
                data_platnosci = paymentDate,
                id_platnosci = paymentId,
                tytul = paymentTitle
            };


            paymentService.AddOrEditPayment(ViewModelMapper.Mapper.Map<PaymentModel>(viewModel));
        }
    }
}