using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 1, temp = 0;


            for (int i = 0; i < args.Length; i++)
            {
                int SizeOfFobanciVariable = int.Parse(args[i]);
                System.Console.Write($"Fibonacci series of {args[i]} result is= {first} {second} {" "} ");
                for (int j = 0; j < SizeOfFobanciVariable; j++)
                {
                    temp = first + second;
                    first = second;
                    second = temp;
                    System.Console.Write($"{temp} {" "}");

                }
                System.Console.WriteLine();
                first = 0;
                second = 1;

            }






        }
    }
}

