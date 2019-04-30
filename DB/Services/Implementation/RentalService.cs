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
    public class RentalService : IRentalService
    {
        //RENTALS
        public bool AddRental(StrictRentalDataModel newRentalData)
        {
            if (newRentalData.id_najemcy == null || newRentalData.id_mieszkania == null)
            {
                return false;       //We cannot setup the rental - leave.
            }

            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var rental = ctx.Wynajmy.FirstOrDefault(x => x.id_mieszkania == newRentalData.id_mieszkania && x.id_najemcy == newRentalData.id_najemcy);
                    if (rental == null)  //DB did not find any record like provided one. Add it.
                    {
                        rental = ModelMapper.Mapper.Map<Wynajmy>(newRentalData);
                        ctx.Wynajmy.Add(rental);
                    }
                    else
                    {
                        return false;       //There's already a rental of this residence for this resident. 
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

        public bool EditRental(StrictRentalDataModel newRentalData)
        {
            if (newRentalData.id_najemcy == null || newRentalData.id_mieszkania == null)
            {
                return false;       //We cannot setup the rental - leave.
            }

            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var rental = ctx.Wynajmy.Find(newRentalData.id_wynajmu);

                    if (rental == null)
                    {
                        return false;
                    }

                    rental.id_najemcy = newRentalData.id_najemcy;
                    rental.id_mieszkania = newRentalData.id_mieszkania;
                    rental.cena_miesieczna = newRentalData.cena_miesieczna;
                    rental.data_rozpoczecia = newRentalData.data_rozpoczecia;
                    rental.data_zakonczenia = newRentalData.data_zakonczenia;
                    
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

        public RentalDataModel GetSingleRentalDataModel(int rentalId)
        {
            var rental = new RentalDataModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.RentalDataView.FirstOrDefault(x => x.id_wynajmu == rentalId);

                    rental = ModelMapper.Mapper.Map<RentalDataModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rental;
        }

        public StrictRentalDataModel GetSingleStrictRentalDataModel(int rentalId)
        {
            var rental = new StrictRentalDataModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Wynajmy.Find(rentalId);

                    rental = ModelMapper.Mapper.Map<StrictRentalDataModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rental;
        }

        public List<RentalDataModel> GetAllRentals()
        {
            var buildings = new List<RentalDataModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.RentalDataView.Select(x => x).AsQueryable();
                    foreach (var rentalDataChunk in queryResult)
                    {
                        buildings.Add(ModelMapper.Mapper.Map<RentalDataModel>(rentalDataChunk));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return buildings;
        }
        
        public void RemoveRental(int rentalId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Wynajmy.Find(rentalId);
                    if (result != null)
                    {
                        ctx.Wynajmy.Remove(result);
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        //PAYMENTS
        public bool AddOrEditPayment(PaymentModel newPayment)
        {
            if (newPayment.id_wynajmu == null)
            {
                return false;       //This payment is not connected to any rental - kinda useless.
            }
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var payment = ctx.Platnosci.Find(newPayment.id_platnosci);
                    if (payment == null)  //DB did not find any record like provided one. Add it.
                    {
                        payment = ModelMapper.Mapper.Map<Platnosci>(newPayment);
                        ctx.Platnosci.Add(payment);
                    }
                    else//There's a record that contains the residence already - modify it.
                    {
                        payment.cena = newPayment.cena;
                        payment.data_platnosci = newPayment.data_platnosci;
                        payment.id_wynajmu = newPayment.id_wynajmu;
                        payment.tytul = newPayment.tytul;
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

        public PaymentModel GetSinglePaymentModel(int paymentId)
        {
            var payment = new PaymentModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Platnosci.Find(paymentId);

                    payment = ModelMapper.Mapper.Map<PaymentModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return payment;
        }

        public List<PaymentModel> GetAllPaymentsById(int rentalId)
        {
            var payments = new List<PaymentModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.Platnosci.Where(x => x.id_wynajmu == rentalId).AsQueryable();
                    foreach (var payment in queryResult)
                    {
                        payments.Add(ModelMapper.Mapper.Map<PaymentModel>(payment));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return payments;
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

        //PAYMENTS BILLS
        public bool AddOrEditPaymentBill(PaymentBillModel newPaymentBill)
        {
            if (newPaymentBill.id_wynajem == null)
            {
                return false;       //This payment is not connected to any rental - kinda useless.
            }
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var payment = ctx.FakturyWynajem.Find(newPaymentBill.id_wynajem);
                    if (payment == null)  //DB did not find any record like provided one. Add it.
                    {
                        payment = ModelMapper.Mapper.Map<FakturyWynajem>(newPaymentBill);
                        ctx.FakturyWynajem.Add(payment);
                    }
                    else//There's a record that contains the residence already - modify it.
                    {
                        payment.cena = newPaymentBill.cena;
                        payment.data_platnosci = newPaymentBill.data_platnosci;
                        payment.id_wynajem = newPaymentBill.id_wynajem;
                        payment.numer_faktury = newPaymentBill.numer_faktury;
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

        public PaymentBillModel GetSinglePaymentBillModel(int paymentBillId)
        {
            var paymentBill = new PaymentBillModel();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.FakturyWynajem.Find(paymentBillId);

                    paymentBill = ModelMapper.Mapper.Map<PaymentBillModel>(queryResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return paymentBill;
        }

        public List<PaymentBillModel> GetAllPaymentBillsById(int rentalId)
        {
            var paymentBills = new List<PaymentBillModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var queryResult = ctx.FakturyWynajem.Where(x => x.id_wynajem == rentalId).AsQueryable();
                    foreach (var paymentBill in queryResult)
                    {
                        paymentBills.Add(ModelMapper.Mapper.Map<PaymentBillModel>(paymentBill));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return paymentBills;
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
