using System;

namespace MultiplicationOfTwoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int Row, Column;
            System.Console.WriteLine("Enter the Row and column of First matrix");
            int.TryParse(Console.ReadLine(), out Row);
            int.TryParse(Console.ReadLine(), out Column);
            int[,] FirstMatrix = new int[Row, Column];
            System.Console.WriteLine("Enter the element in first matrix");
            for (int i = 0; i < FirstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                {
                    FirstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Enter the Row and column of second matrix");
            int.TryParse(Console.ReadLine(), out Row);
            int.TryParse(Console.ReadLine(), out Column);
            int[,] SecondMatrix = new int[Row, Column];
            System.Console.WriteLine("Enter the element in second matrix");
            for (int i = 0; i < SecondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                {
                    SecondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] Multiplication = new int[FirstMatrix.GetLength(0), SecondMatrix.GetLength(1)];
            if (FirstMatrix.GetLength(1) == SecondMatrix.GetLength(0))
            {

                for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < Multiplication.GetLength(1); k++)
                            Multiplication[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
                    }
                }
                Display(Multiplication);
            }
            else
            {
                System.Console.WriteLine("Multiplication is not Possible");
            }

        }
        static public void Display(int[,] Multiplication)
        {
            System.Console.WriteLine("Multiplication of matrix");
            for (int i = 0; i < Multiplication.GetLength(0); i++)
            {
                for (int j = 0; j < Multiplication.GetLength(1); j++)
                {
                    System.Console.Write($"{Multiplication[i, j]} ");
                }
                System.Console.WriteLine();
            }


        }
    }
}
