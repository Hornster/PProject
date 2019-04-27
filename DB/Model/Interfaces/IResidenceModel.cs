﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model.Implementation;

namespace DB.Model.Interfaces
{
    public interface IResidenceModel
    {
        int id_mieszkania { get; set; }
        int? id_budynku { get; set; }
        int numer { get; set; }
        float? metraz { get; set; }
        string opis { get; set; }
        
    }
}
