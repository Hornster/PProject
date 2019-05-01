using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    /// <summary>
    /// Contains useful for system users data about given fault.
    /// </summary>
    public class FaultDataModel : IFaultsDataModel
    {
        public string opis { get; set; }
        public string stan { get; set; }
        public string adres_budynku { get; set; }
        public int numer { get; set; }
        public int id_usterki { get; set; }
        public int id_mieszkania { get; set; }
        public int id_budynku { get; set; }
    }
}
