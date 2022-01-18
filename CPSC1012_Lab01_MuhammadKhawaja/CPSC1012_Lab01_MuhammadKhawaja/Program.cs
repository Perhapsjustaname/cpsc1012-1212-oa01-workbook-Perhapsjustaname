using System;

/*
Purpose: To produce a receipt and display information about a purchase for a customer based off of user inputs 

Input: retailPrice, qauntity

Output: provincialSalesTax (6%), federalSalesTax (5%),subTotal, totalSalesTax, TotalOfSale

Written by: Muhammad H. Khawaja

Written for: Sam Wu

Section A01
*/

namespace CPSC1012_Lab01_MuhammadKhawaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare the variables used 
            double retailPrice,
                quantity,
                provincialSalesTax,
                federalSalesTax,
                subTotal,
                totalSalesTax,
                totalOfSale;

            //prompt user input for the quanity of item and its price
            Console.WriteLine("Welcome to the store! ");

            Console.Write("Please enter the quantity being purchased: ");
            quantity = double.Parse(Console.ReadLine());
            Console.Write("Please enter the price of this item: ");
            retailPrice = double.Parse(Console.ReadLine());

            //start displaying the invoice summary
            Console.WriteLine("________________________________");
            Console.WriteLine("Invoice Summary");
            Console.WriteLine("________________________________");
            Console.WriteLine();

            //Calculate Subtotal and display
            subTotal = quantity * retailPrice;
            Console.WriteLine($"Sub total:{subTotal:C}");
            Console.WriteLine();

            //Calculate the provincial tax, federal and total tax and total of sale
            provincialSalesTax = subTotal * 0.06;
            federalSalesTax = subTotal * 0.05;
            totalSalesTax = provincialSalesTax + federalSalesTax;
            totalOfSale = totalSalesTax + subTotal;

            //Display these values and the total of sale

            Console.WriteLine($"Provincial Tax: {provincialSalesTax:C}");
            Console.WriteLine($"Federal Tax: {federalSalesTax:C}");
            Console.WriteLine($"Total Tax: {totalSalesTax:C}");
            Console.WriteLine();
            Console.WriteLine($"Total Price: {totalOfSale:C}");  
            Console.WriteLine("________________________________");
            Console.WriteLine("Thank you for your purchase.");
            Console.WriteLine("Press any key to exit");


        }
    }
}
