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
    public class PaymentService : IPaymentService
    {
        public List<PaymentModel> GetAllPayments(int rentalId)
        {
            var queryResult = new List<PaymentModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var residents = ctx.Platnosci.Where(x => x.id_wynajmu == rentalId);

                    foreach (var resident in residents)
                    {
                        queryResult.Add(ModelMapper.Mapper.Map<PaymentModel>(resident));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public PaymentModel GetSinglePaymentById(int paymentId)
        {
            PaymentModel queryResult = null;
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var resident = ctx.Platnosci.Find(paymentId);

                    queryResult = ModelMapper.Mapper.Map<PaymentModel>(resident);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public void AddOrEditPayment(PaymentModel newPayment)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var payment = ctx.Platnosci.Find(newPayment.id_platnosci);

                    if (payment == null)
                    {
                        payment = ModelMapper.Mapper.Map<Platnosci>(newPayment);
                        ctx.Platnosci.Add(payment);
                    }
                    else
                    {
                        payment.id_wynajmu = newPayment.id_wynajmu;
                        payment.id_platnosci = newPayment.id_platnosci;
                        payment.cena = newPayment.cena;
                        payment.data_platnosci = newPayment.data_platnosci;
                        payment.tytul = newPayment.tytul;
                    }

                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemovePayment(int paymentId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Platnosci.Find(paymentId);
                    if (result != null)
                    {
                        ctx.Platnosci.Remove(result);
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
