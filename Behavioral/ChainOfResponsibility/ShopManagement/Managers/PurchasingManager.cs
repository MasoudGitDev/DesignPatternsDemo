using Shared.Services;
using ShopManagement.Abstractions;

namespace ShopManagement.Managers;

internal class PurchasingManager(bool isPresent = true) : IManager {
    public int Order => 3;

    public bool IsPresent => isPresent;

    public string Name => nameof(PurchasingManager);

    public bool Process(IProduct product) {
        if(product.Amount > 100) {
            return false;
        }
        if(product.Price >= 2500) {
         
            return  false;
        }
        Logger.Log($"Your request with ID <{product.Id}> has been sold by <{nameof(PurchasingManager)}> successfully.");
        return true;
    }

}



