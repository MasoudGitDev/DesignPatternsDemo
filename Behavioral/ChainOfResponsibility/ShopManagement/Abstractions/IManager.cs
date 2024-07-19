namespace ShopManagement.Abstractions;
internal interface IManager {
    string Name { get; }
    int Order { get; }
    bool IsPresent { get; }
    bool Process(IProduct product);

}
