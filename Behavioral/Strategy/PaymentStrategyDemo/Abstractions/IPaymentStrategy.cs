namespace PaymentStrategyDemo.Abstractions;
internal interface IPaymentStrategy {
    void Pay(decimal amount);
}
