using System;

namespace SecondProgramMultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var multidemsionalArray=new int[2,3,3];
            System.Console.WriteLine("Array length is:"+multidemsionalArray.Length);
            for(int i=0;i<multidemsionalArray.GetLength(0);i++)
            {
                for(int j=0;j<multidemsionalArray.GetLength(1);j++)
                {
                    for(int k=0;k<multidemsionalArray.GetLength(2);k++)
                    {
                        multidemsionalArray[i,j,k]=int.Parse(Console.ReadLine());
                    }
                }
            }
            System.Console.WriteLine("---------------------------");

            for(int i=0;i<multidemsionalArray.GetLength(0);i++)
            {
                for(int j=0;j<multidemsionalArray.GetLength(1);j++)
                {
                    for(int k=0;k<multidemsionalArray.GetLength(2);k++)
                    {
                        System.Console.WriteLine($"multidimensional {i}{j}{k}={multidemsionalArray[i,j,k]} ");
                    }
                }
                    System.Console.WriteLine();
            }
        }
    }
}
