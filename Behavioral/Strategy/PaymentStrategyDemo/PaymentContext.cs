using PaymentStrategyDemo.Abstractions;
using Shared.Services;

namespace PaymentStrategyDemo;
internal class PaymentContext {

    private IPaymentStrategy? _paymentStrategy;
    public void SetStrategy(IPaymentStrategy strategy) {
        _paymentStrategy = strategy;
    }

    public void Pay(decimal amount) {
        if(amount <= 0) {
            Logger.Log($"The amount ({amount}) must be greater than 0.");
            return;
        }
        if(_paymentStrategy is null) {
            Logger.Log("Please choose a payment strategy.");
            return;
        }
        _paymentStrategy.Pay(amount);
    }
}
