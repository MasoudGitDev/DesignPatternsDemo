using Bridge.Abstractions;

namespace Bridge.MessageLength;

internal class ShortMessage : AbstractMessage {
    public ShortMessage(IMessageSender messageSender) : base(messageSender) {
    }
    public override void Send() {
        Console.WriteLine("Message-Type : " + nameof(ShortMessage));
        base.Send();
    }
}
