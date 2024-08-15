using PaymentStrategyDemo.Abstractions;

namespace PaymentStrategyDemo.Strategies;
internal class CreditCardStrategy(string cardNumber , string cardHolderName) : IPaymentStrategy {
    public void Pay(decimal amount) {
        Console.WriteLine($"Paid {amount:C} using Credit Card: {cardNumber}, Card Holder: {cardHolderName}");
    }
}