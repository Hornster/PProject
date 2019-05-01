using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PProject.Models.PaymentBills
{
    public class PaymentBillListViewModel : ListViewModel<PaymentBillViewModel>
    {
        public int RentalId { get; set; }
    }
}