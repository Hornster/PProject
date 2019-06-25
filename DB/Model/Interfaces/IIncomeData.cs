namespace DB.Model.Interfaces
{
    public interface IIncomeData
    {
        int BuildingId { get; set; }

        string Address { get; set; }

        double Income { get; set; }

        double Expense { get; set; }

        double Profit { get; set; }
    }
}