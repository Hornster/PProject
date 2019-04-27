using System.Collections.Generic;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class ResidentModel : IResidentModel
    {
        public int id_najemcy { get; set; }
        public string nr_telefonu { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string PESEL { get; set; }
    }
}
