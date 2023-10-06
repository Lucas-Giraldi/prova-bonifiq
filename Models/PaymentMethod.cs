namespace ProvaPub.Models
{
    public interface IPaymentMethod
    {

        Task<bool> ProcessPayment(decimal paymentValue);

    }
}
