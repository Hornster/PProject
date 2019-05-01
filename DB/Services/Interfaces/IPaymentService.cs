using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface IPaymentService
    {
        /// <summary>
        /// Gets all payments assigned to given rental.
        /// </summary>
        /// <param name="rentalId"></param>
        /// <returns></returns>
        List<PaymentModel> GetAllPayments(int rentalId);
        /// <summary>
        /// Gets single payment by provided ID. Or null if none found.
        /// </summary>
        /// <param name="paymentId"></param>
        /// <returns></returns>
        PaymentModel GetSinglePaymentById(int paymentId);
        /// <summary>
        /// Edits, or adds if unable to find, a payment.
        /// </summary>
        /// <param name="newPayment"></param>
        void AddOrEditPayment(PaymentModel newPayment);
        /// <summary>
        /// Removes payment of provided ID from the system.
        /// </summary>
        /// <param name="paymentId"></param>
        void RemovePayment(int paymentId);
    }
}
