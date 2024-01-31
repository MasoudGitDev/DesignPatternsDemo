using Command.Logger;

namespace Command.ValueObjects;
public class Price {
    public decimal Main { get; }
    public decimal Sell { get; set; }
    public Price(decimal main =  0, decimal sell = 0) {
        if(sell < main) {
            throw new Exception("sell price must be equal or greater than main price.");
        }
        Main = main;
        Sell = sell;
    }
    public Price() {
        Main = Sell = 0;
    }
}
