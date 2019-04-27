using System;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class RepairModel : IRepairModel
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
