using Prototype.Model;
using Shared.Services;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, Prototype Pattern!\n");


try {
    var (mainBookShop, branch1) = CreateMainBookShop();

    Logger.CreateTitle("Operations");
    branch1.Sell("BookName1");
    branch1.ChangeShopInfo("Branch1", 2);

    branch1.UpdateISBN("BookName2" , "ISBN-BK_2");
    branch1.UpdatePrice("BookName3" , 9999);
    branch1.ChangeName("BranchShop1");



    CreateBookShopDetails(mainBookShop , branch1);
}
catch (Exception ex) {
    Console.WriteLine();
    Logger.Log(ex.Message);
}




(BookShop mainbookShop , BookShop branch1) CreateMainBookShop() {
    var books = new LinkedList<Book>();
    for(int i = 1 ; i <= 10 ; i++) {
        books.AddLast(new Book() {
           Name =  "BookName" + i ,
           Price = 1000 + i ,
           Info = new BookInfo() {
                ISBN = ( "ISBN" + i ) ,
                OtherThings = ( "OtherThings" + i )
            }
        }); 
    }
    var mainBookShop = new BookShop(){
        Name = "MainBookShop" ,
        Books = books ,
        Info = new ShopInfo(){
            Description = "Main" ,
            Rank = 1
        }
    };
    var branch1 =  mainBookShop.ShallowCopy(); // choose Copy types
    CreateBookShopDetails(mainBookShop , branch1);  
    return (mainBookShop,branch1);
}
void CreateBookShopDetails(BookShop mainBookShop , BookShop branch1) {
    Logger.CreateTitle("MainBookShop Books");
    Console.WriteLine(mainBookShop);

    Logger.CreateTitle("Branch1 Books");
    Console.WriteLine(branch1);
}


