﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model.Interfaces;

namespace PProject.Models.Rentals
{
    public class RentalDataViewModel : IRentalDataModel
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int numer { get; set; }
        public string adres_budynku { get; set; }
        public DateTime? data_rozpoczecia { get; set; }
        public DateTime? data_zakonczenia { get; set; }
        public float? cena_miesieczna { get; set; }
        public int id_najemcy { get; set; }
        public int id_budynku { get; set; }
        public int id_mieszkania { get; set; }
        public int id_wynajmu { get; set; }
    }
}