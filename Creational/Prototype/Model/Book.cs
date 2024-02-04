namespace Prototype.Model;
internal class Book {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public BookInfo Info { get; set; }
    public override string ToString() {
        return $"[{Name} : {Price}] : [{Info.ISBN}] => BookHashCode:{this.GetHashCode()}";
    }

}

internal class BookInfo {
    public string ISBN { get; set; }
    public string? OtherThings { get; set; }
}
