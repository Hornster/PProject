using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface IRentalService
    {
        //RENTALS
        /// <summary>
        /// Tries to edit, or adds if unable to find, a rental. Make sure the najemca and mieszkanie IDs are not null or will fail.
        /// </summary>
        /// <param name="newRentalData"></param>
        /// <returns>True if managed to add. False otherwise.</returns>
        bool AddOrEditRental(StrictRentalDataModel newRentalData);
        /// <summary>
        /// Returns a single rental data model.Has all data required to show to the user. Or null if none found.
        /// </summary>
        /// <param name="rentalId"></param>
        /// <returns></returns>
        RentalDataModel GetSingleRentalDataModel(int rentalId);
        /// <summary>
        /// Returns a single strict rental data model which contains only data about the rental itself. Or null if none found.
        /// </summary>
        /// <param name="rentalId">Used to determine what rental object to return.</param>
        /// <returns></returns>
        StrictRentalDataModel GetSingleStrictRentalDataModel(int rentalId);
        /// <summary>
        /// Returns all rentals data models. These have all data required to show to the user.
        /// </summary>
        /// <param name="rentalId"></param>
        /// <returns></returns>
        List<RentalDataModel> GetAllRentals();
        /// <summary>
        /// Removes rental of given ID.
        /// </summary>
        /// <param name="rentalId"></param>
        void RemoveRental(int rentalId);
        

        //PAYMENTS
        /// <summary>
        /// Adds, or edits if already present, a payment.
        /// </summary>
        /// <param name="newPayment"></param>
        /// <returns></returns>
        bool AddOrEditPayment(PaymentModel newPayment);
        /// <summary>
        /// Returns single payment model of given ID. Or null if none found.
        /// </summary>
        /// <param name="paymentId"></param>
        /// <returns></returns>
        PaymentModel GetSinglePaymentModel(int paymentId);
        /// <summary>
        /// Returns all payments assigned to provided rental ID.
        /// </summary>
        /// <param name="rentalId"></param>
        /// <returns></returns>
        List<PaymentModel> GetAllPaymentsById(int rentalId);
        /// <summary>
        /// Removes a single payment of given ID.
        /// </summary>
        /// <param name="paymentId"></param>
        void RemovePayment(int paymentId);
        

        //PAYMENTS BILLS
        /// <summary>
        /// Adds, or edits if already present, a new payment bill.
        /// </summary>
        /// <param name="newPaymentBill"></param>
        /// <returns></returns>
        bool AddOrEditPaymentBill(PaymentBillModel newPaymentBill);
        /// <summary>
        /// Returns a single payment bill. Or null if none found.
        /// </summary>
        /// <param name="paymentBillId"></param>
        /// <returns></returns>
        PaymentBillModel GetSinglePaymentBillModel(int paymentBillId);
        /// <summary>
        /// Returns all payment bills assigned to rental of provided ID.
        /// </summary>
        /// <param name="rentalId"></param>
        /// <returns></returns>
        List<PaymentBillModel> GetAllPaymentBillsById(int rentalId);
        /// <summary>
        /// Removes payment bill from the system.
        /// </summary>
        /// <param name="paymentBillId"></param>
        void RemovePaymentBill(int paymentBillId);

    }
}
