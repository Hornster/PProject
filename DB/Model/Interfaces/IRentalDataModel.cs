using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model.Interfaces
{
    /// <summary>
    /// A wide version of rental data providing information about rental and building,
    /// resident and residence, whom the rental concerns.
    /// </summary>
    public interface IRentalDataModel
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        int numer { get; set; }
        string adres_budynku { get; set; }
        DateTime? data_rozpoczecia { get; set; }
        DateTime? data_zakonczenia { get; set; }
        float? cena_miesieczna { get; set; }
        int id_najemcy { get; set; }
        int id_budynku { get; set; }
        int id_mieszkania { get; set; }
        int id_wynajmu { get; set; }
    }
}
