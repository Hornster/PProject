using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model.Interfaces;

namespace PProject.Models.PaymentBills
{
    public class PaymentBillViewModel : IPaymentBillModel
    {
        public int id_faktury { get; set; }
        public int? id_wynajem { get; set; }
        public float cena { get; set; }
        public int numer_faktury { get; set; }
        public DateTime? data_platnosci { get; set; }
    }
}