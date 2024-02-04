using Shared.Extensions;
using Shared.Services;
using System.Text;

namespace Prototype.Model;

internal class BookShop{

    public required string Name { get; set; }
    public LinkedList<Book> Books { get; set; } = new();
    public ShopInfo Info { get; set; } = new();

    public void Sell(string bookName) {
        var findBookByName = Books.FirstOrDefault(x => x.Name == bookName).ThrowIfNull($"The {bookName} book not exist.");
        Books.Remove(findBookByName);
        Logger.Log($"\nThe <{bookName}> book was sold.");
    }

    public void UpdateISBN(string bookName , string ISBN) {
        var findBookByName = Books.FirstOrDefault(x => x.Name == bookName).ThrowIfNull($"The {bookName} book not exist.");
        Books.Find(findBookByName)!.Value.Info.ISBN = ISBN;
        Logger.Log($"\nThe <{bookName}> ISBN changed to {ISBN}");
    }

    public void UpdatePrice(string bookName , decimal price) {
        var findBookByName = Books.FirstOrDefault(x => x.Name == bookName).ThrowIfNull($"The {bookName} book not exist.");
        Books.Find(findBookByName)!.Value.Price = price;
        Logger.Log($"\nThe <{bookName}> Price changed to {price}");
    }

    public void ChangeName(string name) {
        Name = name;
        Logger.Log($"\nThe BookShopName is changed to : " + name);
    }

    public void ChangeShopInfo(string description , int rank) {
        Info.Rank = rank;
        Info.Description = description;
    }





    public override string ToString() {
        StringBuilder sb = new();
        foreach(var book in Books) {
            sb.Append($"{Name} : {book}\n");
        }
        sb.Append("ShopHashCode : " + this.GetHashCode() + "\n");
        sb.Append(Info);
        return sb.ToString();
    }



    public BookShop RefrenceCopy() => this;
    public BookShop DeepCopy() => new BookShop { Name = Name , Books = Books };
    public BookShop ShallowCopy() => (BookShop) this.MemberwiseClone();

}

internal class ShopInfo {
    public string Description { get; set; }
    public int Rank { get; set; }

    public override string ToString() {
        return $"ShopInfo : [Description : {Description} , Rank : {Rank} , HashCode : {GetHashCode()}]";
    }
}