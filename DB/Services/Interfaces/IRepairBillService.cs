using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface IRepairBillService
    {
        /// <summary>
        /// Edits, or adds if none found, a repair bill.
        /// </summary>
        /// <param name="newRepairBill"></param>
        /// <returns></returns>
        bool AddOrEditRepairBill(RepairBillModel newRepairBill);
        /// <summary>
        /// Returns single repair bill using provided ID. Or null if none found.
        /// </summary>
        /// <param name="repairBillId"></param>
        /// <returns></returns>
        RepairBillModel GetSingleRepairBillModel(int repairBillId);
        /// <summary>
        /// Returns all repair bills assigned to given repair ID.
        /// </summary>
        /// <param name="repairId"></param>
        /// <returns></returns>
        List<RepairBillModel> GetAllRepairBillsById(int repairId);
        /// <summary>
        /// Removes given repair bill from the system.
        /// </summary>
        /// <param name="repairBillId"></param>
        void RemoveRepairBill(int repairBillId);
    }
}
