using Bridge.Abstractions;
using Shared.Services;

namespace Bridge.MessageTypes;
internal class EmailMessage(string message) : IMessageSender {
    public void Send() {
        Logger.Log($"Message-Sender : Email");
        Logger.Log("Message : " + message + "\n");
    }
}
