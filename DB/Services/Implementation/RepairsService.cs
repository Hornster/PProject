using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model;
using DB.Model.Implementation;
using DB.Services.Interfaces;

namespace DB.Services.Implementation
{
    public class RepairsService : IRepairsService
    {
        public List<RepairModel> GetAllRepairs()
        {
            var repairs = new List<RepairModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Naprawy.Select(x => x).AsQueryable();
                    foreach (var repair in queryResult)
                    {
                        repairs.Add(ModelMapper.Mapper.Map<RepairModel>(repair));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return repairs;
        }
    }
}
