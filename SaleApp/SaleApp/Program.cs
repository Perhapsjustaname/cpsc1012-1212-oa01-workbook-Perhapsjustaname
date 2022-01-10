using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price,
                tax,
                total;

            price = 29.75;
            tax = 1.76;
            total = 31.51;

            Console.WriteLine($"The price of the item is {price:C}");
            Console.WriteLine($"The tax of the item is {tax:C}");
            Console.WriteLine($"The total of the item is {total:C}");
        }
    }
}
