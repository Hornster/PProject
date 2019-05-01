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
    public class FaultService : IFaultService
    {
        //FAULTS
        public bool AddOrEditFault(FaultModel newFaultData)
        {
            if (newFaultData.id_mieszkania == null)
            {
                return false;       //We cannot setup the fault - leave.
            }

            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var fault = ctx.Usterki.Find(newFaultData.id_usterki);

                    if (fault == null)
                    {
                        fault = ModelMapper.Mapper.Map<Usterki>(newFaultData);
                        ctx.Usterki.Add(fault);
                    }
                    else
                    {
                        fault.id_usterki = newFaultData.id_usterki;
                        fault.id_mieszkania = newFaultData.id_mieszkania;
                        fault.opis = newFaultData.opis;
                        fault.stan = newFaultData.stan;
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

        public List<FaultDataModel> GetAllFaultsData()
        {
            var faults = new List<FaultDataModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.FaultsDataView.Select(x => x).AsQueryable();
                    foreach (var faultDataChunk in queryResult)
                    {
                        faults.Add(ModelMapper.Mapper.Map<FaultDataModel>(faultDataChunk));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return faults;
        }

        public FaultDataModel GetSingleFaultDataModel(int faultId)
        {
            var rental = new FaultDataModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.FaultsDataView.FirstOrDefault(x => x.id_usterki == faultId);

                    rental = ModelMapper.Mapper.Map<FaultDataModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rental;
        }

        public FaultModel GetSingleStrictFaultDataModel(int faultId)
        {
            var fault = new FaultModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Usterki.Find(faultId);

                    fault = ModelMapper.Mapper.Map<FaultModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return fault;
        }

        public void RemoveFault(int faultId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Usterki.Find(faultId);
                    if (result != null)
                    {
                        ctx.Usterki.Remove(result);
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
