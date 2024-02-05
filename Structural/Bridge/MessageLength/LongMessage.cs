using Bridge.Abstractions;

namespace Bridge.MessageLength;
internal class LongMessage : AbstractMessage {
    public LongMessage(IMessageSender messageSender):base(messageSender) {
    }
    public override void Send() {
        Console.WriteLine("Message-Type : " + nameof(LongMessage));
        base.Send();
    }
}
