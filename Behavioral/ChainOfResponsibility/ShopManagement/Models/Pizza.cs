using ShopManagement.Abstractions;

namespace ShopManagement.Models;
internal class Pizza(int amount) : IProduct {
    public string Id => "Pizza1";

    public int Amount => amount;

    public decimal Price => 10;

    public string Name => nameof(Pizza);
}