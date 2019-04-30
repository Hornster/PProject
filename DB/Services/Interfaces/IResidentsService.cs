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
        /// <summary>
        /// Returns single resident saved under provided ID or null if none found.
        /// </summary>
        /// <param name="residentId"></param>
        /// <returns></returns>
        ResidentModel GetSingleResident(int residentId);
        /// <summary>
        /// Returns single resident saved under provided PESEL or null if none found.
        /// </summary>
        /// <param name="residentPesel"></param>
        /// <returns></returns>
        ResidentModel GetSingleResident(string residentPesel);
        /// <summary>
        /// Edits or adds (if record not yet present) a resident.
        /// </summary>
        /// <param name="newResident">Data of the resident to edit/add.</param>
        void AddOrEditResident(ResidentModel newResident);
        /// <summary>
        /// Removes resident identified with provided ID.
        /// </summary>
        /// <param name="residentId"></param>
        void RemoveResident(int residentId);

    }
}
