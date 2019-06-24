using System;
using System.Collections.Generic;
using System.Linq;
using DB.Mappers;
using DB.Model.Implementation;
using DB.Model.Interfaces;
using DB.Services.Interfaces;

namespace DB.Services.Implementation
{
    public class LatePaymentService : ILatePaymentService
    {
        public IList<ILatePaymentModel> GetAllLatePayments()
        {
            var queryResult = new List<ILatePaymentModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    IEnumerable<Wynajmy> activeRentals = ctx.Wynajmy.Where(x => x.data_rozpoczecia < DateTime.Now && x.data_zakonczenia > DateTime.Now).ToList();

                    foreach (var rental in activeRentals)
                    {
                        var expectedAmount = 0.0;
                        var totalPayments = 0.0;

                        var dateDifference = DateTime.Today - rental.data_rozpoczecia;
                        var months = Math.Round(dateDifference.Value.TotalDays / 30);

                        if ((dateDifference.Value.TotalDays / 30) > 0
                            && (dateDifference.Value.TotalDays / 30) < 1)
                            months = 1;

                        expectedAmount = months * Convert.ToDouble(rental.cena_miesieczna);

                        var allPaymentsForRental = ctx.Platnosci.Where(x => x.id_wynajmu == rental.id_wynajmu).ToList();

                        totalPayments = allPaymentsForRental.Sum(x => x.cena);

                        if (expectedAmount > totalPayments)
                        {

                            var flat = ctx.Mieszkania.First(x => x.id_mieszkania == rental.id_mieszkania);
                            var building = ctx.Budynki.First(x => x.id_budynku == flat.id_budynku);
                            var debtor = ctx.Najemcy.First(x => x.id_najemcy == rental.id_najemcy);

                            string resident = $"{debtor.imie} {debtor.nazwisko}";
                            string telephone = $"{debtor.nr_telefonu}";
                            string location = $"{building.adres_budynku}/{flat.numer}";

                            var latePayment = new LatePaymentModel()
                            {
                                Amount = expectedAmount - totalPayments,
                                Name = resident,
                                Mobile = telephone,
                                Address = location
                            };

                            queryResult.Add(latePayment);
                        }
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