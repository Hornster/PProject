using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class StrictRentalDataModel : IStrictRentalDataModel
    {
        public int id_wynajmu { get; set; }
        public int? id_mieszkania { get; set; }
        public DateTime? data_rozpoczecia { get; set; }
        public DateTime? data_zakonczenia { get; set; }
        public int? id_najemcy { get; set; }
        public float? cena_miesieczna { get; set; }
    }
}
