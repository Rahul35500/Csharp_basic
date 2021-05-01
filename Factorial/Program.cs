using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, Factorial = 1;
            System.Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Factorial *= i;
            }
            System.Console.WriteLine($"Factorial of {number} is {Factorial}");
        }
    }
}
