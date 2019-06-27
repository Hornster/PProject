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
        //REPAIRS
        public bool AddOrEditRepair(RepairModel newRepair)
        {
            if (newRepair.id_usterki == null)
            {
                return false;       //This repair is not connected to any fault - kinda useless.
            }
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var repair = ctx.Naprawy.Find(newRepair.id_naprawy);
                    if (repair == null)  //DB did not find any record like provided one. Add it.
                    {
                        repair = ModelMapper.Mapper.Map<Naprawy>(newRepair);
                        ctx.Naprawy.Add(repair);
                    }
                    else//There's a record that contains the residence already - modify it.
                    {
                        repair.id_naprawy = newRepair.id_naprawy;
                        repair.data_rozpoczecia = newRepair.data_rozpoczecia;
                        repair.data_ukonczenia = newRepair.data_ukonczenia;
                        repair.data_zlecenia = newRepair.data_zlecenia;
                        repair.id_firmy = newRepair.id_firmy;
                        repair.id_usterki = repair.id_usterki;
                        repair.stan = newRepair.stan;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public RepairModel GetSingleRepairModel(int repairId)
        {
            var payment = new RepairModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Naprawy.Find(repairId);

                    payment = ModelMapper.Mapper.Map<RepairModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return payment;
        }

        public List<RepairModel> GetAllRepairsById(int faultId)
        {
            var repairs = new List<RepairModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Naprawy.Where(x => x.id_usterki == faultId);
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

        public void RemoveRepair(int repairId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Naprawy.Find(repairId);
                    if (result != null)
                    {
                        ctx.Naprawy.Remove(result);
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot delete provided repair - remove connected bills first.");
            }
        }


    }
}
