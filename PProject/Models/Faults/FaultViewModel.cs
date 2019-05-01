using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model.Interfaces;

namespace PProject.Models.Faults
{
    public class FaultViewModel : IFaultModel
    {
        public int id_usterki { get; set; }
        public int? id_mieszkania { get; set; }
        public string opis { get; set; }
        public string stan { get; set; }
    }
}