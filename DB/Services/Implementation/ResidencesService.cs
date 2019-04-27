using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model.Implementation;
using DB.Services.Interfaces;

namespace DB.Services.Implementation
{
    public class ResidencesService : IResidencesService
    {
        public List<BuildingModel> GetAllBuildings()
        {
            var buildings = new List<BuildingModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Budynki.Select(x => x).AsQueryable();
                    foreach (var building in queryResult)
                    {
                        buildings.Add(ModelMapper.Mapper.Map<BuildingModel>(building));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return buildings;
        }

        public List<ResidenceModel> GetResidencesById(int buildingId)
        {
            var residences = new List<ResidenceModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Mieszkania.Where(x=>x.id_budynku == buildingId).AsQueryable();
                    foreach (var building in queryResult)
                    {
                        residences.Add(ModelMapper.Mapper.Map<ResidenceModel>(building));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return residences;
        }
    }
}
