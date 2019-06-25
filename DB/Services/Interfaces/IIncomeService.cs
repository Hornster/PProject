using System;
using System.Collections.Generic;
using DB.Model.Interfaces;

namespace DB.Services.Interfaces
{
    public interface IIncomeService
    {
        IList<IIncomeData> GetIncomeForBuildings(IEnumerable<int> buildingIds = null, DateTime? startDate = null, DateTime? endDate = null);
    }
}