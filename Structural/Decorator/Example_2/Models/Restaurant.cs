using Decorator.Example_2.Abstractions;
using Shared.Services;
using System.Text;

namespace Decorator.Example_2.Models;
internal class Restaurant {
    private decimal _reservedOptionsPrice = 0;
    private StringBuilder _reservedOptionsName = new();
    public Restaurant(params IRestaurantOption[] options)
    {
        uint count = 1;
        foreach (var option in options) {
            _reservedOptionsName.Append(option.Name);
            _reservedOptionsPrice += option.Price;
            Logger.Log($"{count} : [ {option.Name} : {option.Price} ] was reserved.");
            count++;
        }
        if(options.Length > 0) {
            var nameResult = _reservedOptionsName.ToString().Remove(_reservedOptionsName.Length-2);
            _reservedOptionsName.Clear();
            _reservedOptionsName.Append(nameResult);            
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        sb.Append("Names : ");
        var names = _reservedOptionsName.ToString();
        sb.Append(String.IsNullOrWhiteSpace(names) ? "NoOption" : names) ;
        sb.Append("\n");
        sb.Append("Prices : ");
        sb.Append(_reservedOptionsPrice);
        return sb.ToString();
    }
}
