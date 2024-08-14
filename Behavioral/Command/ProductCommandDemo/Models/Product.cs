using Shared.Services;

namespace ProductCommandDemo.Models;
internal sealed record Product(string Name , decimal MainPrice , decimal SellPrice) {
    public static Product New(string name , decimal mainPrice , decimal sellPrice) => new(name , mainPrice,sellPrice);
}

internal static class ProductExtensions {

    public static Product IncreaseSellPrice(this Product product , decimal amount) {
        decimal prevSellPrice = product.SellPrice;
        product = product with { SellPrice = product.SellPrice + amount };
        Logger.Log($"Undo: The <sell-price> has been increased from {prevSellPrice} to {product.SellPrice} | amount : {amount}");
        return product;
    }

    public static Product DecreaseSellPrice(this Product product , decimal amount) {
        decimal prevSellPrice = product.SellPrice;
        product = product with { SellPrice = product.SellPrice - amount };
        Logger.Log($"The <sell-price> has been decreased from {prevSellPrice} to {product.SellPrice} | amount : {amount}");
        return product;
    }

    public static Product SetDiscount(this Product product , decimal percentage) {
        if(percentage < 0) {
            Logger.Log($"Invalid number : The Percentage must be positive number ({percentage})");
            return product;
        }
        decimal prevSellPrice = product.SellPrice;
        product = product with { SellPrice = product.SellPrice - ( product.SellPrice * ( percentage / 100 ) ) };
        Logger.Log($"The <sell-price> has been decreased from {prevSellPrice} to {product.SellPrice} | percentage : {percentage}");
        return product;
    }

    public static Product PopDiscount(this Product product , decimal percentage) {
        if(percentage < 0) {
            Logger.Log($"Invalid number : The Percentage must be positive number ({percentage})");
            return product;
        }
        decimal prevSellPrice = product.SellPrice;
        // Correct calculation to reverse the exact discount applied in SetDiscount
        decimal originalPrice = product.SellPrice / (1 - (percentage / 100));
        product = product with { SellPrice = originalPrice };
        Logger.Log($"The <sell-price> has been decreased from {prevSellPrice} to {product.SellPrice} | percentage : {percentage}");
        return product;
    }

}
