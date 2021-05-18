using System;

namespace GroupOfArray
{
    class Program
    {

        static void Main(string[] args)
        {
            int[][] arr = new int[3][] { new int[] {4, 2, 7, 1},
            new int[] { 20, 70, 40, 90 }, new int[] { 1, 2, 0 }};
            System.Console.Write("Largest element in array [");
            for (int i = 0; i < findSituation(arr).Length; i++)
            {
                System.Console.Write($"{findSituation(arr)[i]} ");
            }
            System.Console.WriteLine("]");
            

        }
        static int[] findSituation(int[][] arr)
        {
            var largest = new int[3];
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > value)
                    {
                        value = arr[i][j];

                    }

                }
                largest[i] = value;
                value = 0;

            }
            return largest;
        }
    }
}
