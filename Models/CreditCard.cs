namespace ProvaPub.Models
{
    public class CreditCard : IPaymentMethod
    {
        public Task<bool> ProcessPayment(decimal paymentValue)
        {

            //Método de pagamento por cartão de crédito
            return Task.FromResult(true);
        }
    }
}
