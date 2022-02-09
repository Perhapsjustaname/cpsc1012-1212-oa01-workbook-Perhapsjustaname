using System;

namespace Decision_Making_Problems_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //practice question 1 

            //ask the customer which package they want (A,B, or  C) amd hours if A or B



            Console.WriteLine("Please enter your package selected (A, B or C): ");
            string package = (Console.ReadLine());
            Console.WriteLine("You have selected package: "+ package);
            

            switch (package) {

                case "A" :
                    
                    Console.WriteLine("Please enter your hours used: ");
                    int hours = int.Parse(Console.ReadLine());
                    if (hours <= 10)
                    {
                        Console.WriteLine("Your bill is: " + hours * 9.95);
                    }
                    else {
                        int extraHours = hours - 10;
                        Console.WriteLine("Your bill is: " + (hours * 9.95) + (extraHours * 2));
                    }
                   
                    break;

                case "B":
                    Console.WriteLine("A");
                    break;

                case "C":
                    Console.WriteLine("A");
                    break;



            }



        }
    }
}
