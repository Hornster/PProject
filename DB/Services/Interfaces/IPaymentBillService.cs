using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface IPaymentBillService
    {
        List<PaymentBillModel> GetAllPaymentBills(int rentalId);

        PaymentBillModel GetSinglePaymentBillById(int paymentBillId);

        void AddOrEditPaymentBill(PaymentBillModel newPaymentBill);

        void RemovePaymentBill(int paymentBillId);
    }
}
