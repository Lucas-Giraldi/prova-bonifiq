namespace ProvaPub.Models
{
    public class Pix : IPaymentMethod
    {
        public Task<bool> ProcessPayment(decimal paymentValue)
        {
            paymentValue *= 2;
            //Método de pagamento por pix
            return Task.FromResult(true);
        }
    }
}
