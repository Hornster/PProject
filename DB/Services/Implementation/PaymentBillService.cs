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
    public class PaymentBillService : IPaymentBillService
    {
        public List<PaymentBillModel> GetAllPaymentBills(int rentalId)
        {
            var queryResult = new List<PaymentBillModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var residents = ctx.FakturyWynajem.Where(x => x.id_wynajem == rentalId);

                    foreach (var resident in residents)
                    {
                        queryResult.Add(ModelMapper.Mapper.Map<PaymentBillModel>(resident));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public PaymentBillModel GetSinglePaymentBillById(int paymentBillId)
        {
            PaymentBillModel queryResult = null;
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var resident = ctx.FakturyWynajem.Find(paymentBillId);

                    queryResult = ModelMapper.Mapper.Map<PaymentBillModel>(resident);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public void AddOrEditPaymentBill(PaymentBillModel newPaymentBill)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var paymentBill = ctx.FakturyWynajem.Find(newPaymentBill.id_faktury);

                    if (paymentBill == null)
                    {
                        paymentBill = ModelMapper.Mapper.Map<FakturyWynajem>(newPaymentBill);
                        ctx.FakturyWynajem.Add(paymentBill);
                    }
                    else
                    {
                        paymentBill.id_wynajem = newPaymentBill.id_wynajem;
                        paymentBill.id_faktury = newPaymentBill.id_faktury;
                        paymentBill.cena = newPaymentBill.cena;
                        paymentBill.data_platnosci = newPaymentBill.data_platnosci;
                        paymentBill.numer_faktury = newPaymentBill.numer_faktury;
                    }

                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemovePaymentBill(int paymentBillId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.FakturyWynajem.Find(paymentBillId);
                    if (result != null)
                    {
                        ctx.FakturyWynajem.Remove(result);
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
