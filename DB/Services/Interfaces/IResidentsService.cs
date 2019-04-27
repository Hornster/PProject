using System.Collections.Generic;
using DB.Model;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface IResidentsService
    {
        /// <summary>
        /// Returns list of all residents found in the database.
        /// </summary>
        /// <returns></returns>
        List<ResidentModel> GetAllResidents();
    }
}
