using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PProject.Models.Companies;

namespace PProject.Models.Repairs
{
    public class RepairEditViewModel
    {
        public RepairViewModel Repair { get; set; }
        public CompanyViewModel CommissionedCompany { get; set; }
    }
}