using Shared.Services;
using ShopManagement.Abstractions;

namespace ShopManagement.Managers;
internal class HeadChef(bool isPresent = true) : IManager {
    public int Order => 2;

    public bool IsPresent => isPresent;

    public string Name => nameof(HeadChef);

    public bool Process(IProduct product) {
        if(product.Amount >= 500) {
            return false;
        }
        if(product.Price >= 5000) {

            return false;
        }
        Logger.Log($"Your request with ID <{product.Id}> has been sold by <{nameof(HeadChef)}> successfully.");
        return true;
    }

}

