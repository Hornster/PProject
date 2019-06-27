using System.Collections.Generic;

namespace DB.Model.Interfaces
{
    public interface IBuildingProfit
    {
        double IncomeFromBuilding { get; set; }

        double ExpensureOnBuilding { get; set; }

        IList<Platnosci> IncomeList { get; set; }

        IList<FakturyNapraw> ExpensureList { get; set; }

        double Profit();
    }
}