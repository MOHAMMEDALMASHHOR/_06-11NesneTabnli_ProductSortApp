// // var numbers = new List<int>();
// List<int> numbers = new List<int>();
// numbers.Add(53);
// numbers.Add(76);
// numbers.Add(51);
// numbers.Add(63);
// numbers.Add(43);
// System.Console.WriteLine($"The size of the list is: {numbers.Count}");
// foreach (var number in numbers)
// {
//     System.Console.WriteLine(number);
// }
// System.Console.WriteLine(new string('-',20));
// numbers.Sort();
// foreach (var number in numbers)
// {
//     System.Console.WriteLine(number);
// }
// Console.ReadLine();

using SortApp.Models;

var products = new List<Product>();
products.Add(new Product("Computer",4_000));
products.Add(new Product(){Name = "Airpdos",Price = 4_000});
products.Add(new Product(){Name = "Car",Price = 500_000});
products.Add(new Product(){Name = "Telephone",Price = 60_000});
products.Add(new Product(){Name = "Laptop",Price = 80_000});

System.Console.WriteLine($"The size of the list is: {products.Count}");
foreach (var product in products)
{
    System.Console.WriteLine(product);
}
System.Console.WriteLine(new string('-',20));
products.Sort();
foreach (var product in products)
{
    System.Console.WriteLine(product);
}
//Listedeki ilk elemanin bit klonunu olusturma
//derin copya
var clone = products[0].Clone();
//klonladigin elemanin fiyati ve adini yazdir
// System.Console.WriteLine(clone.Name);cunku clone simdi bir objedir Product degil!!!
System.Console.WriteLine(((Product)clone).Name);
System.Console.WriteLine();
//
System.Console.WriteLine(clone);//the output will be override tostring, but 
System.Console.WriteLine(clone.GetType());//the output will be namespace

// Console.ReadLine();