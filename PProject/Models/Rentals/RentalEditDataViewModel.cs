using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PProject.Models.Rentals
{
    public class RentalEditDataViewModel
    {
        public int RentalId { get; set; }
        public string PESEL { get; set; }
        public int ResidenceNumber { get; set; }
        public string BuildingAddress { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiringDate { get; set; }
        public float? RentalPrice { get; set; }

    }
}