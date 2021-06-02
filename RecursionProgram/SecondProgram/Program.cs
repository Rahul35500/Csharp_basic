using System;

namespace SecondProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of terms for the Fibonacci series : ");
            long number=long.Parse(Console.ReadLine());
            System.Console.Write($"The Fibonacci series of {number} term is :");
            for(long i=0;i<number;i++)
            {
                System.Console.Write($"{Fibonacci(i)} ");
            }

        }
        static long Fibonacci(long number)
        {
            long FirstNumber = 0;
            long LastNumber = 1;
            for (long i = 0; i < number; i++)
            {
                long temp = FirstNumber;
                FirstNumber = LastNumber;
                LastNumber = temp + FirstNumber;
            }
            return FirstNumber;

        }
    }
}
