using PaymentStrategyDemo.Abstractions;

namespace PaymentStrategyDemo.Strategies;

public class PayPalPaymentStrategy(string email) : IPaymentStrategy {

    public void Pay(decimal amount) {
        Console.WriteLine($"Paid {amount:C} using PayPal Account: {email}");
    }
}
