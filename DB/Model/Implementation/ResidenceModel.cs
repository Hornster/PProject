using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class ResidenceModel :IResidenceModel
    {
        public int id_mieszkania { get; set; }
        public int? id_budynku { get; set; }
        public int numer { get; set; }
        public float? metraz { get; set; }
        public string opis { get; set; }
    }
}
