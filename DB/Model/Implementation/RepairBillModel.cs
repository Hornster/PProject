using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class RepairBillModel : IRepairBillModel
    {
        public int id_faktury { get; set; }
        public int? id_naprawy { get; set; }
        public float cena { get; set; }
        public int numer_faktury { get; set; }
        public DateTime? data_platnosci { get; set; }
    }
}
