using System.Collections.Generic;
using DB.Model.Implementation;

namespace DB.Model.Interfaces
{
    public interface IBuildingModel
    {
        int id_budynku { get; set; }
        string adres_budynku { get; set; }
    }
}
