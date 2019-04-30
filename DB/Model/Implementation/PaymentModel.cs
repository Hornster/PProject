using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class PaymentModel : IPaymentModel
    {
        public int id_platnosci { get; set; }
        public int? id_wynajmu { get; set; }
        public DateTime? data_platnosci { get; set; }
        public float cena { get; set; }
        public string tytul { get; set; }
    }
}
