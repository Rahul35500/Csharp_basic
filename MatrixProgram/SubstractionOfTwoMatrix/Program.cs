using System;

namespace SubstractionOfTwoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int Row, Column;
            System.Console.WriteLine("Enter the Row and column of First and Second matrix");
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
            int[,] SecondMatrix = new int[Row, Column];
            System.Console.WriteLine("Enter the element in second matrix");
            for (int i = 0; i < SecondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                {
                    SecondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] Substraction=new int[Row,Column];

            for (int i = 0; i < FirstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                {
                    Substraction[i,j]=FirstMatrix[i,j]-SecondMatrix[i,j];
                }
            }
            System.Console.WriteLine("Substraction of matrix");
            for (int i = 0; i < Substraction.GetLength(0); i++)
            {
                for (int j = 0; j < Substraction.GetLength(1); j++)
                {
                    System.Console.Write($"{Substraction[i,j]} " );
                }
                System.Console.WriteLine();
            }
        }
    }
}
