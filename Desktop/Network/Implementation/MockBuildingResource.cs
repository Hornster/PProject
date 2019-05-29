using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.Model.Data;
using Desktop.Network.Interfaces;

namespace Desktop.Network.Implementation
{
    class MockBuildingResource : IBuildingResource
    {
        public bool AddBuilding(Building building)
        {
            return true;
        }

        public bool EditBuilding(Building building)
        {
            return true;
        }

        public Building GetBuilding(int id)
        {
            return new Building()
            {
                Id = 1,
                Address = "Gliwice"
            };
        }

        public List<Building> GetBuildings()
        {
            List<Building> bld = new List<Building>();
            bld.Add(new Building()
            {
                Id = 0,
                Address = "Gliwice, Pjusudzkiego 12"
            });
            bld.Add(new Building()
            {
                Id = 1,
                Address = "Gliwice, Armii Krajowej 3"
            });
            bld.Add(new Building()
            {
                Id = 2,
                Address = "Gliwice, Einsteina -12"
            });
            bld.Add(new Building()
            {
                Id = 3,
                Address = "Gliwice, Ordona 12"
            });
            return bld;
        }

        public bool RemoveBuilding(int id)
        {
            throw new NotImplementedException();
        }
    }
}
