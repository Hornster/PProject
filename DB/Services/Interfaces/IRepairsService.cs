using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    /// <summary>
    /// Used to send queries to database that concern repairs.
    /// </summary>
    public interface IRepairsService
    {
        /// <summary>
        /// Edits, or adds if none found, a repair model.
        /// </summary>
        /// <param name="newRepair"></param>
        /// <returns></returns>
        bool AddOrEditRepair(RepairModel newRepair);
        /// <summary>
        /// If found, returns a single repair model, using its ID to find it.
        /// </summary>
        /// <param name="repairId"></param>
        /// <returns></returns>
        RepairModel GetSingleRepairModel(int repairId);
        /// <summary>
        /// Gets all repairs assigned to fault of given ID.
        /// </summary>
        /// <param name="faultId"></param>
        /// <returns></returns>
        List<RepairModel> GetAllRepairsById(int faultId);
        /// <summary>
        /// Removes a repair from system.
        /// </summary>
        /// <param name="repairId"></param>
        void RemoveRepair(int repairId);
    }
}
