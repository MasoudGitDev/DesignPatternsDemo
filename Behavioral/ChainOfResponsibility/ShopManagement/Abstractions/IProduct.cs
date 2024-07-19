namespace ShopManagement.Abstractions;
internal interface IProduct {
    string Id { get; }
    int Amount { get; }
    decimal Price { get; }
    string Name { get; }
}
