using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class IncomeData : IIncomeData
    {
        public int BuildingId { get; set; }

        public string Address { get; set; }

        public double Income { get; set; }
        
        public double Expense { get; set; }

        public double Profit { get; set; }
    }
}