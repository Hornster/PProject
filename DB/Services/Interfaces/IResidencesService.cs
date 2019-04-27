using System.Collections.Generic;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface IResidencesService
    {
        /// <summary>
        /// Returns all buildings contained in the database
        /// </summary>
        /// <returns></returns>
        List<BuildingModel> GetAllBuildings();
        /// <summary>
        /// Gets all residences assigned to building.
        /// </summary>
        /// <param name="buildingId">Building id.</param>
        /// <returns></returns>
        List<ResidenceModel> GetResidencesById(int buildingId);
    }
}
