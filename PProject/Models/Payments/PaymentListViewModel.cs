namespace PProject.Models.Payments
{
    public class PaymentListViewModel : ListViewModel<PaymentViewModel>
    {
        public int RentalId { get; set; }
    }
}