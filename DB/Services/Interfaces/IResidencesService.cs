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
        /// <summary>
        /// Returns a single residence, if found any. If not - returns null, most likely.
        /// </summary>
        /// <param name="buildingId"></param>
        /// <param name="residenceId"></param>
        /// <returns></returns>
        ResidenceModel GetSingleResidence(int buildingId, int residenceId);
        /// <summary>
        /// Returns a single building, if found any. If not - returns null, most likely.
        /// </summary>
        /// <param name="buildingId"></param>
        /// <returns></returns>
        BuildingModel GetSingleBuilding(int buildingId);
        /// <summary>
        /// Wipes out given residence from the database.
        /// </summary>
        /// <param name="buildingId"></param>
        /// <param name="residenceId"></param>
        void RemoveResidence(int buildingId, int residenceId);
        /// <summary>
        /// Tries to update provided residence. If resembling row doesn't exist - adds it to the DB.
        /// </summary>
        /// <param name="newResidence"></param>
        void AddOrEditResidence(ResidenceModel newResidence);
        /// <summary>
        /// Tries to update provided building. If resembling row doesn't exist - adds it to the DB.
        /// </summary>
        /// <param name="newBuilding"></param>
        void AddOrEditBuilding(BuildingModel newBuilding);
    }
}
