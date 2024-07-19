using ShopManagement.Abstractions;

namespace ShopManagement;
internal class ShopManager(IEnumerable<IManager> _managers) :IShopManager {
    public void Sell(IProduct product) {
        foreach(var manager in _managers.OrderByDescending(x => x.Order)) {
            if(manager.Process(product)) {
                break;
            }
        }
    }
}
