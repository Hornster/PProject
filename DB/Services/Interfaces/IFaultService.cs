using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface IFaultService
    {
        /// <summary>
        /// Edits, or add if not found any, a fault.
        /// </summary>
        /// <param name="newFaultData"></param>
        /// <returns></returns>
        bool AddOrEditFault(FaultModel newFaultData);
        /// <summary>
        /// Returns all faults. All o them.
        /// </summary>
        /// <returns></returns>
        List<FaultDataModel> GetAllFaultsData();
        /// <summary>
        /// Returns single fault data (useful for users) basing on passed ID. Or null if none found.
        /// </summary>
        /// <param name="faultId"></param>
        /// <returns></returns>
        FaultDataModel GetSingleFaultDataModel(int faultId);
        /// <summary>
        /// Returns single fault data using provided ID. Or null, if found none.
        /// </summary>
        /// <param name="faultId"></param>
        /// <returns></returns>
        FaultModel GetSingleStrictFaultDataModel(int faultId);
        /// <summary>
        /// Gets rid of given fault.
        /// </summary>
        /// <param name="faultId"></param>
        void RemoveFault(int faultId);
    }
}
