/*  Purpose: computer the total of a sales item using the price and tax
 
    Inputs: Price  in dollars
 
    Outputs: Sales total 

    Algorithm: Step 1) Prompt and read in the sale price
               Step 2) Calculate the sale total using the formula:
                      sale total = price * tax
               Step 3) Display the computed sale total
Last Modified: Jan 12, 2022
 */ 

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

            Console.WriteLine("Please enter the sale price: ");
            price = double.Parse(Console.ReadLine());
            tax = (price*1.05)-price;
            total = price + tax;

            Console.WriteLine($"The price of the item is {price:C}");
            Console.WriteLine($"The tax of the item is {tax:C}");
            Console.WriteLine($"The total of the item is {total:C}");
        }
    }
}
