using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Model.Data;
namespace Desktop.Network.Interfaces
{
    interface IBuildingResource
    {
        List<Building> GetBuildings();
        Building GetBuilding(int id);
        bool AddBuilding(Building building);
        bool EditBuilding(Building building);
        bool RemoveBuilding(int id);
    }
}
