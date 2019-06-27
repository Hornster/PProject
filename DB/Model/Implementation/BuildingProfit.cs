using System.Collections.Generic;
using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class BuildingProfit : IBuildingProfit
    {
        public double IncomeFromBuilding { get; set; }

        public double ExpensureOnBuilding { get; set; }

        public IList<Platnosci> IncomeList { get; set; }

        public IList<FakturyNapraw> ExpensureList { get; set; }

        public double Profit()
        {
            return IncomeFromBuilding - ExpensureOnBuilding;
        }
    }
}