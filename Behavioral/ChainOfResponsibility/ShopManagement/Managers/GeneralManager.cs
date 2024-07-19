using Shared.Services;
using ShopManagement.Abstractions;

namespace ShopManagement.Managers;

internal class GeneralManager(bool isPresent = true) : IManager {
    public int Order => 1;

    public bool IsPresent => isPresent;

    public string Name => nameof(GeneralManager);

    public bool Process(IProduct product) {
        if(product.Amount >= 1000 || product.Price >= 10000) {
            Logger.Log($"Your request for {product.Name} with ID : <{product.Id}> requires a meeting due to high amount or price.");
            return false;
        }
        Logger.Log($"Your request with ID <{product.Id}> has been sold by <{nameof(GeneralManager)}> successfully.");
        return true;
    }

}



