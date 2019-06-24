namespace DB.Model.Interfaces
{
    public interface ILatePaymentModel
    {
        double Amount { get; set; }

        string Name { get; set; }

        string Mobile { get; set; }

        string Address { get; set; }
    }
}