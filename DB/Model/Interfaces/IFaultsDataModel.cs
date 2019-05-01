using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model.Interfaces
{
    /// <summary>
    /// For classes that should contain most significant data for the users about given faults
    /// </summary>
    public interface IFaultsDataModel
    {
        string opis { get; set; }
        string stan { get; set; }
        string adres_budynku { get; set; }
        int numer { get; set; }
        int id_usterki { get; set; }
        int id_mieszkania { get; set; }
        int id_budynku { get; set; }
    }
}
