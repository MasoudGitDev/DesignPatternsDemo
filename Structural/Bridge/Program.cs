// See https://aka.ms/new-console-template for more information
using Bridge.MessageLength;
using Bridge.MessageTypes;

Console.WriteLine("Hello, Bridge Pattern! \n");

string message = "This is a simple Message";
var sms = new ShortMessage(new SMSMessage(message));
sms.Send();

