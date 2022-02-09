using System;

namespace ChineseZodiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input their birth year
            Console.WriteLine("Please enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());
            birthYear = birthYear % 12;
            string sign;
            
            switch (birthYear)
            {

                case 0:
                    sign = "monkey";
                    Console.WriteLine("Your Chinese Zodiac sign is: "+ sign);
                    break;
                case 1:
                    sign = "rooster";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 2:
                    sign = "dog";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 3:
                    sign = "pig";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 4:
                    sign = "rat";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 5:
                    sign = "ox";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 6:
                    sign = "tiger";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 7:
                    sign = "rabbit";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 8:
                    sign = "dragon";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 9:
                    sign = "snake";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 10:
                    sign = "horse";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
                case 11:
                    sign = "sheep";
                    Console.WriteLine("Your Chinese Zodiac sign is: " + sign);
                    break;
               

            }

            
            
            }
        }
    }

