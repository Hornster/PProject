using System;
using System.Collections.Generic;
using System.Linq;
using DB.Mappers;
using DB.Model;
using DB.Model.Implementation;
using DB.Services.Interfaces;

namespace DB.Services.Implementation
{
    public class ResidentsService :IResidentsService
    {
        public List<ResidentModel> GetAllResidents()
        {
            var queryResult = new List<ResidentModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var residents = ctx.Najemcy.Select(x => x).AsQueryable();

                    foreach (var resident in residents)
                    {
                        queryResult.Add(ModelMapper.Mapper.Map<ResidentModel>(resident));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public ResidentModel GetSingleResident(int residentId)
        {
            ResidentModel queryResult = null;
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var resident = ctx.Najemcy.Find(residentId);
                    
                    queryResult = ModelMapper.Mapper.Map<ResidentModel>(resident);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public void AddOrEditResident(ResidentModel newResident)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var resident = ctx.Najemcy.Find(newResident.id_najemcy);

                    if (resident == null)
                    {
                        resident = ModelMapper.Mapper.Map<Najemcy>(newResident);
                        ctx.Najemcy.Add(resident);
                    }
                    else
                    {
                        resident.imie = newResident.imie;
                        resident.nazwisko = newResident.nazwisko;
                        resident.nr_telefonu = newResident.nr_telefonu;
                        resident.PESEL = newResident.PESEL;
                    }

                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveResident(int residentId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Najemcy.Find(residentId);
                    if (result != null)
                    {
                        ctx.Najemcy.Remove(result);
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
