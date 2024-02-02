namespace ChainOfResponsibility.Abstractions;
internal abstract class ChainSellHandler {
    public abstract bool Sell(IFood food);
    public virtual bool IsPresent { get; private set; }

}
internal interface IFood {
    public decimal Price { get;}
    public string Name { get; }
}


