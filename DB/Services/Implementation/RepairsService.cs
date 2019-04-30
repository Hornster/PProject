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

        public List<FaultModel> GetFaultsById(int repairId)
        {
            var residences = new List<FaultModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    //var queryResult = ctx.Usterki.Where(x => x. == buildingId).AsQueryable();
                    //foreach (var building in queryResult)
                    //{
                    //    residences.Add(ModelMapper.Mapper.Map<FaultModel>(building));
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return residences;
        }

        public RepairModel GetSingleRepair(int repairId)
        {
            var repair = new RepairModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Naprawy.Find(repairId);

                    repair = ModelMapper.Mapper.Map<RepairModel>(queryResult);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return repair;
        }


    }
}
