using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model.Interfaces;

namespace PProject.Models.Rentals
{
    public class StrictRentalDataViewModel : IStrictRentalDataModel
    {
        public int id_wynajmu { get; set; }
        public int? id_mieszkania { get; set; }
        public DateTime? data_rozpoczecia { get; set; }
        public DateTime? data_zakonczenia { get; set; }
        public int? id_najemcy { get; set; }
        public float? cena_miesieczna { get; set; }
    }
}