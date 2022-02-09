using System;

namespace Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int students = 10;
            int pass = 0;
            int fail = 0;
            while (students > 0)
            {
                Console.Write("Enter result (1 = pass , 2 = fail):");
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    pass = pass + 1;
                    students--;

                }
                else if (result == 2)
                {
                    fail = fail + 1;
                    students--;
                }
                else {
                    Console.WriteLine("Invalid entry, please try again.");
                }

            }

            Console.WriteLine($"Pass:{pass}");
            Console.WriteLine($"Fail:{fail}");


        }
    }
}
