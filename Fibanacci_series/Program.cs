using System;

namespace Fibanacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, number;
            n1 = 0;
            n2 = 1;
            Console.WriteLine("Enter the number of elements");
            number = int.Parse(Console.ReadLine());
            System.Console.Write($"{n1} {n2} ");
            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                System.Console.Write($"{n3} ");

            }

        }
    }
}
