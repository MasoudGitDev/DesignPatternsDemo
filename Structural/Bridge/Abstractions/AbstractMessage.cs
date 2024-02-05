namespace Bridge.Abstractions;
internal abstract class AbstractMessage(IMessageSender _messageSender) {
    public virtual void Send() => _messageSender.Send();
}
