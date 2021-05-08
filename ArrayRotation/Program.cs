using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            const long Mod = 100000007;
            long Size_of_array, sum = 0, queries;
            Console.WriteLine("Enter the size of the array");
            Size_of_array = Convert.ToInt64(Console.ReadLine());
            long[] array = new long[Size_of_array];
            Console.WriteLine("Enter the list of the array");
            for (int i = 0; i < Size_of_array; i++)
            {
                array[i] = Convert.ToInt64(Console.ReadLine());
                sum = (sum + array[i]) % Mod;
            }
            Console.WriteLine("Enter the number of query");
            queries = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < queries; i++)
            {
                sum = (2 * sum) % Mod;
            }
            Console.WriteLine($"sum of element of the current array: {sum}");
        }
    }
}
