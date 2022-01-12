using System;

namespace WagesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                // read user input for basePay, regularHours, overtimePay, overTimeHours
                Console.WriteLine("Enter your regular hours worked: ");
                double regularHours = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your base pay :$ ");
                double basePay = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your overtime hours worked: ");
                double overtimeHours = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your overtime pay :$ ");
                double overtimePay = double.Parse(Console.ReadLine());

                //calculate total wages

                double regularWages = basePay * regularHours;
                double overtimeWages = overtimePay * overtimeHours;
                double totalWages = regularWages + overtimeWages;
                
                //display the total wage
                
                Console.WriteLine("Wages for this week are $" + totalWages);
              
            }
            
        }
    }
}
