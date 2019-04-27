using System.Collections.Generic;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class BuildingModel :IBuildingModel
    {
        public int id_budynku { get; set; }
        public string adres_budynku { get; set; }
    }
}
