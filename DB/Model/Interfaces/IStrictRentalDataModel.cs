using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model.Interfaces
{
    /// <summary>
    /// Used to save or modify data about given rental.
    /// </summary>
    public interface IStrictRentalDataModel
    {
        int id_wynajmu { get; set; }
        int? id_mieszkania { get; set; }
        DateTime? data_rozpoczecia { get; set; }
        DateTime? data_zakonczenia { get; set; }
        int? id_najemcy { get; set; }
        float? cena_miesieczna { get; set; }
    }
}
