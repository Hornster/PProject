using System.Collections.Generic;
using DB.Model.Interfaces;

namespace DB.Services.Interfaces
{
    public interface ILatePaymentService
    {
        IList<ILatePaymentModel> GetAllLatePayments();
    }
}