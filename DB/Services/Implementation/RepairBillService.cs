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
    public class RepairBillService : IRepairBillService
    {
        //REPAIRS BILLS
        public bool AddOrEditRepairBill(RepairBillModel newRepairBill)
        {
            if (newRepairBill.id_naprawy == null)
            {
                return false;       //This repair bill is not connected to any repair - kinda useless.
            }
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var repairBill = ctx.FakturyNapraw.Find(newRepairBill.id_faktury);
                    if (repairBill == null)  //DB did not find any record like provided one. Add it.
                    {
                        repairBill = ModelMapper.Mapper.Map<FakturyNapraw>(newRepairBill);
                        ctx.FakturyNapraw.Add(repairBill);
                    }
                    else//There's a record that contains the residence already - modify it.
                    {
                        repairBill.cena = newRepairBill.cena;
                        repairBill.data_platnosci = newRepairBill.data_platnosci;
                        repairBill.id_naprawy = newRepairBill.id_naprawy;
                        repairBill.numer_faktury = newRepairBill.numer_faktury;
                        repairBill.id_faktury = newRepairBill.id_faktury;
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

        public RepairBillModel GetSingleRepairBillModel(int repairBillId)
        {
            var repairBill = new RepairBillModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.FakturyNapraw.Find(repairBillId);

                    repairBill = ModelMapper.Mapper.Map<RepairBillModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return repairBill;
        }

        public List<RepairBillModel> GetAllRepairBillsById(int repairId)
        {
            var paymentBills = new List<RepairBillModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.FakturyNapraw.Where(x => x.id_naprawy == repairId);
                    foreach (var paymentBill in queryResult)
                    {
                        paymentBills.Add(ModelMapper.Mapper.Map<RepairBillModel>(paymentBill));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return paymentBills;
        }

        public void RemoveRepairBill(int repairBillId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.FakturyNapraw.Find(repairBillId);
                    if (result != null)
                    {
                        ctx.FakturyNapraw.Remove(result);
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not fulfill the request.");
            }
        }
    }
}
