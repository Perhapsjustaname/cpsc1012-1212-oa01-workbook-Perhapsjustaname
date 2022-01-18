using System;

namespace SubtractionQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generate two random single digit integers

            Random generateNum = new Random();
            int number1 = generateNum.Next(1, 10);
            int number2 = generateNum.Next(1, 10);

            //swap if number 1 is smaller than number 2

            if (number1 < number2)
            {
                int tempNumber = number1;
                number1 = number2;
                number2 = tempNumber;
            };
            //ask for the answer from user

            Console.WriteLine($"What is {number1} - {number2}?");
            int answer = int.Parse(Console.ReadLine());

            //check this answer

            if (answer == (number1 - number2))
            {
                Console.WriteLine("This is correct!");
            }
            else
            {
                Console.WriteLine($"This is wrong. The answer is {number1 - number2}");

            }
        }
    }
}
