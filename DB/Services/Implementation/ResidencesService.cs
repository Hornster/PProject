using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ResidenceModel GetSingleResidence(int buildingId, int residenceId)
        {
            var residence = new ResidenceModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Mieszkania.FirstOrDefault(x => x.id_budynku == buildingId && x.id_mieszkania == residenceId);
                    
                    residence = ModelMapper.Mapper.Map<ResidenceModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return residence;
        }

        public BuildingModel GetSingleBuilding(int buildingId)
        {
            var building = new BuildingModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Budynki.Find(buildingId);

                    building = ModelMapper.Mapper.Map<BuildingModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return building;
        }

        public void RemoveResidence(int buildingId, int residenceId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Mieszkania.FirstOrDefault(x => x.id_budynku == buildingId && x.id_mieszkania == residenceId);
                    if (result != null)
                    {
                        ctx.Mieszkania.Remove(result);
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveBuilding(int buildingId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Budynki.Find(buildingId);
                    if (result != null)
                    {
                        ctx.Budynki.Remove(result);
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void AddOrEditResidence(ResidenceModel newResidence)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var residence = ctx.Mieszkania.FirstOrDefault(x => x.id_budynku == newResidence.id_budynku && x.id_mieszkania == newResidence.id_mieszkania);
                    if (residence == null)  //DB did not find any record like provided one. Add it.
                    {
                        residence = ModelMapper.Mapper.Map<Mieszkania>(newResidence);
                        ctx.Mieszkania.Add(residence);
                    }
                    else//There's a record that contains the residence already - modify it.
                    {
                        residence.numer = newResidence.numer;
                        residence.metraz = newResidence.metraz;
                        residence.opis = newResidence.opis;
                        //ctx.Entry(residence).State = EntityState.Modified;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddOrEditBuilding(BuildingModel newBuilding)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var building = ctx.Budynki.Find(newBuilding.id_budynku);
                    if (building == null)  //DB did not find any record like provided one. Add it.
                    {
                        building = ModelMapper.Mapper.Map<Budynki>(newBuilding);
                        ctx.Budynki.Add(building);
                    }
                    else//There's a record that contains the residence already - modify it.
                    {
                        building.adres_budynku = newBuilding.adres_budynku;
                        //ctx.Entry(residence).State = EntityState.Modified;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
