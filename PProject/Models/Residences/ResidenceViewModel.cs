﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model.Interfaces;

namespace PProject.Models.Residences
{
    public class ResidenceViewModel : IResidenceModel
    {
        public int id_mieszkania { get; set; }
        public int? id_budynku { get; set; }
        public int numer { get; set; }
        public float? metraz { get; set; }
        public string opis { get; set; }
    }
}