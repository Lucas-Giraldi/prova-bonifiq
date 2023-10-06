using ProvaPub.Models;

namespace ProvaPub.Services
{
    public class OrderService
    {

        private readonly Dictionary<string, IPaymentMethod> _paymentMethods = new Dictionary<string, IPaymentMethod>
{
    { "pix", new Pix() },
    { "creditcard", new CreditCard() },
    { "paypal", new PayPal() },
};


        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
        {
            //if (paymentMethod == "pix")
            //{
            //    //Faz pagamento...
            //}
            //else if (paymentMethod == "creditcard")
            //{
            //    //Faz pagamento...
            //}
            //else if (paymentMethod == "paypal")
            //{
            //    //Faz pagamento...
            //}

            if (_paymentMethods.TryGetValue(paymentMethod, out var paymentValueInstance))
            {
                await paymentValueInstance.ProcessPayment(paymentValue);
            }

            return await Task.FromResult(new Order()
            {
                Value = paymentValue
            });
        }
    }
}
