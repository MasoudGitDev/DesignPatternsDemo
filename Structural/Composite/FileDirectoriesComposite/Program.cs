// See https://aka.ms/new-console-template for more information
using FileDirectoriesComposite.Models;

Console.WriteLine("Hello, Composite Pattern!\n");

var file1 = new FileItem("file1" , 1);
var file2 = new FileItem("file2" , 2);
var file3= new FileItem("file3" , 3);
var file4 = new FileItem("file4" , 4);
var file5 = new FileItem("file5" , 4);


//==================== directory 3
var directory3= new DirectoryItem("directory3 :" , 3);
directory3.Add(file4);
directory3.Add(file5);

//==================== directory 2
var directory2= new DirectoryItem("directory2 :" , 2);
directory2.Add(file3);
directory2.Add(directory3);

//==================== directory 1
var directory1 = new DirectoryItem("directory1 :" , 1);
directory1.Add(file2);
directory1.Add(directory2);

//=============root
var root = new DirectoryItem("Root :" , 0);
root.Add(file1);
root.Add(directory1);

//===================== Show all details
root.GetDetails();
