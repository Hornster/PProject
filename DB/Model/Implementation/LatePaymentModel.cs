using DB.Model.Interfaces;

namespace DB.Model.Implementation
{
    public class LatePaymentModel : ILatePaymentModel
    {
        public double Amount { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }
    }
}