using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model.Interfaces;

namespace PProject.Models.Companies
{
    public class CompanyViewModel : ICompanyModel
    {
        public int id_firmy { get; set; }
        public string NIP { get; set; }
        public string nr_telefonu { get; set; }
        public string nazwa_firmy { get; set; }
    }
}