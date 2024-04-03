// See https://aka.ms/new-console-template for more information
using System.Net;

string greeting = @"Welcome to Thrown for a Loop
Your one-stop shop for used sporting equipment";
Console.WriteLine(greeting);

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name ="Football",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12.00M,
        Sold = false,
        StockDate = new DateTime(2022, 8, 13),
        ManufactureYear = 2012,
        Condition = 3.9
    },
    new Product()
    {
        Name = "Soccer Ball",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2023, 11, 3),
        ManufactureYear = 2013,
        Condition = 4.3
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 5.00M,
        Sold = false,
        StockDate = new DateTime(2022, 12, 1),
        ManufactureYear = 2011,
        Condition = 4.9
    },
    new Product()
    {
        Name = "Golf Club",
        Price = 18.00M,
        Sold = false,
        StockDate = new DateTime(2023, 1, 23),
        ManufactureYear = 2012,
        Condition = 2.5
    },
    new Product()
    {
        Name = "Volleyball",
        Price = 13.00M,
        Sold = true,
        StockDate = new DateTime(2022, 9, 11),
        ManufactureYear = 2011,
        Condition = 3.6
    }
    //curly braces serve as an 'object initializer'
};

decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}");

Console.WriteLine(@"Products:");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
// Console.WriteLine("Please enter a product number: ");
// int response = int.Parse(Console.ReadLine().Trim());
// while (response > products.Count || response < 1)
// {
//     Console.WriteLine("Choose a number between 1 and 5!");
//     response = int.Parse(Console.ReadLine().Trim());
// }


// Product chosenProduct = products[response - 1];
Product chosenProduct = null;
while (chosenProduct == null)
{
    Console.WriteLine("Please enter a product number: ");
    try
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine("Do better!");

    }


}
DateTime now = DateTime.Now;
TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old.
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")} ");

