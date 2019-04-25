using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Interfaces.Model;

namespace PProject.Models.Residents
{
    public class ResidentViewModel : IResidentModel
    {
        public int id_najemcy { get; set; }
        public string nr_telefonu { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string PESEL { get; set; }
        public ICollection<Wynajmy> Wynajmy { get; set; }
    }
}