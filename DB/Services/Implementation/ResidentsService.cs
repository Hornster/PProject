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
    }
}
