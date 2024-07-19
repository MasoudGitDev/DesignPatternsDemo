using ShopManagement.Abstractions;

namespace ShopManagement.Models;

internal class Hamburger(int amount) : IProduct {
    public string Id => "Hamburger1";

    public int Amount => amount;

    public decimal Price => 10;

    public string Name => nameof(Hamburger);
}