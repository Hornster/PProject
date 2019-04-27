using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB;
using DB.Model.Interfaces;

namespace PProject.Models.Repairs
{
    public class RepairViewModel : IRepairModel
    {
        public int id_naprawy { get; set; }
        public int? id_usterki { get; set; }
        public int? id_firmy { get; set; }
        public string nr_telefonu { get; set; }
        public string stan { get; set; }
        public DateTime? data_zlecenia { get; set; }
        public DateTime? data_rozpoczecia { get; set; }
        public DateTime? data_ukonczenia { get; set; }
    }
}