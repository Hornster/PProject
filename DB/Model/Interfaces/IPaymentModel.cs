using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model.Interfaces
{
    public interface IPaymentModel
    {
        int id_platnosci { get; set; }
        int? id_wynajmu { get; set; }
        DateTime? data_platnosci { get; set; }
        float cena { get; set; }
        string tytul { get; set; }
    }
}
