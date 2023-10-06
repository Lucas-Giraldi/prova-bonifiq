namespace ProvaPub.Models
{
    public class PayPal :IPaymentMethod
    {
        public Task<bool> ProcessPayment(decimal paymentValue)
        {

            paymentValue += 1;

            //Método de pagamento usando PayPal
            return Task.FromResult(true);
        }
    }
}
