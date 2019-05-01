using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model.Interfaces;

namespace PProject.Models.Payments
{
    public class PaymentViewModel : IPaymentModel
    {
        public int id_platnosci { get; set; }
        public int? id_wynajmu { get; set; }
        public DateTime? data_platnosci { get; set; }
        public float cena { get; set; }
        public string tytul { get; set; }
    }
}