using System;
/**************************************************************************************/

//Purpose: To construct a practical metric conversion program 

//Input:User selected operation for conversion, input value for that conversion

//Output: Value when successfully converted

//Written by: Muhammad Khawaja

//Written for: Sam Wu

//Section A01

//******************************************************************************************
namespace CPSC1012_Lab2_MuhammadKhawaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value,
                convertedValue;
            int conversionOption;

            //Present options and introduce to user
            Console.WriteLine("**********Converson Calculator**********");
            Console.WriteLine("Please choose from the following menu: ");
            Console.WriteLine("     1)Inches to Centimeters");
            Console.WriteLine("     2)Yards to Meters");
            Console.WriteLine("     3)Miles to Kilometers");
            Console.WriteLine("     4)Exit");

            //request user input for selection from the menu
            conversionOption = int.Parse(Console.ReadLine());

            switch (conversionOption)
            {
              
                case 1:
                    //User has selected Inches to centimeters converstion
                    {
                        Console.Write("Please enter a value in inches: ");
                        value = double.Parse(Console.ReadLine());
                        //convert the inches value to cm
                        convertedValue = value * 2.54;
                        Console.WriteLine($"The value of {value} inches is {convertedValue} cm");
                        Console.WriteLine("Good Bye!");
                    }
                    break;
                case 2:
                    //User has selected Yards to Meters converstion
                    {
                        Console.Write("Please enter a value in yards: ");
                        value = double.Parse(Console.ReadLine());
                        //convert the yards value to meters
                        convertedValue = value * 0.9144;
                        Console.WriteLine($"The value of {value} yards is {convertedValue} meters");
                        Console.WriteLine("Good Bye!");
                    }
                  
                    break;
                case 3: 
                    //User has selected Miles to kilometers converstion
                    {
                        Console.Write("Please enter a value in miles: ");
                        value = double.Parse(Console.ReadLine());
                        //convert the miles value to kilometers
                        convertedValue = value * 1.60934;
                        Console.WriteLine($"The value of {value} miles is {convertedValue} kilometers");
                        Console.WriteLine("Good Bye!");
                    }
                    
                    break;
                case 4:
                    //if user selects to exit, close the application
                    Console.WriteLine("Exit. Goodbye.");
                   
                    break;
                    
               default:
                    //user inputs anything other than the menu items
                    Console.WriteLine("INVALID selection, good bye!");
                    break;


            }
            
          
        }
    }
}
