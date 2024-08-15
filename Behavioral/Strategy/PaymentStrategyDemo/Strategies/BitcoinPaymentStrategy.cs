using PaymentStrategyDemo.Abstractions;

namespace PaymentStrategyDemo.Strategies;

public class BitcoinPaymentStrategy(string walletAddress) : IPaymentStrategy {
    public void Pay(decimal amount) {
        Console.WriteLine($"Paid {amount:C} using Bitcoin Wallet: {walletAddress}");
    }
}