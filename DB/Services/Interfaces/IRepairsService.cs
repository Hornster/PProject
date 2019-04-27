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
        /// Gets all repairs from the database.
        /// </summary>
        /// <returns></returns>
        List<RepairModel> GetAllRepairs();
    }
}
