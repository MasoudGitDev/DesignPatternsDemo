using PaymentStrategyDemo;
using PaymentStrategyDemo.Strategies;
using Shared.Services;

Console.WriteLine("Hello, Strategy Pattern!\n");

var paymentManager = new PaymentContext();

Logger.CreateTitle("Payment-Strategy : Bitcoin");
paymentManager.SetStrategy(new BitcoinPaymentStrategy("bitcoin-address"));
paymentManager.Pay(1000);

Logger.NextLine();

Logger.CreateTitle("Payment-Strategy : PayPal");
paymentManager.SetStrategy(new PayPalPaymentStrategy("email-address"));
paymentManager.Pay(5000);

Logger.NextLine();

Logger.CreateTitle("Payment-Strategy : CreditCard");
paymentManager.SetStrategy(new CreditCardStrategy("123456" , "test-HolderName"));
paymentManager.Pay(6000);
