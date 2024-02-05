using Bridge.Abstractions;
using Shared.Services;

namespace Bridge.MessageTypes;

internal class SMSMessage(string message) : IMessageSender {
    public void Send() {      
        Logger.Log($"Message-Sender : SMS");
        Logger.Log("Message : " + message + "\n");
    }
}
