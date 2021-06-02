using System;

namespace FirstProgramOfTwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstExample = new int[4, 5];
            System.Console.WriteLine("Enter the element in second dimesional array");
            for (int i = 0; i < firstExample.GetLength(0); i++)
            {
                for (int j = 0; j < firstExample.GetLength(1); j++)
                {
                    firstExample[i, j] = int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Display the second/Two dimesional");
            for (int i = 0; i < firstExample.GetLength(0); i++)
            {
                for (int j = 0; j < firstExample.GetLength(1); j++)
                {
                    System.Console.Write($"{firstExample[i, j]}  ");
                }
                System.Console.WriteLine();
            }


        }
    }
}
