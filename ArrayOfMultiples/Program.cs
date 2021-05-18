using System;

namespace ArrayOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number which you want in multiples");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            System.Console.WriteLine("Enter the length of multiples");
            int length;
            int.TryParse(Console.ReadLine(), out length);
            for (int i = 0; i < ArrayMultiples(number, length).Length; i++)
            {
                System.Console.Write($"{ArrayMultiples(number, length)[i]} {" "}");
            }
        }
        public static int[] ArrayMultiples(int number, int length)
        {
            int[] arraySecond = new int[length];
            int j = 1;
            for (int i = 0; i < length; i++)
            {
                arraySecond[i] = number * j;
                j++;
            }
            return arraySecond;
        }
    }

}
