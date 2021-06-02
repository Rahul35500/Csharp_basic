using System;

namespace ArrayOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj=new Program();
            System.Console.WriteLine("Enter the number which you want in multiples");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            System.Console.WriteLine("Enter the length of multiples");
            int length;
            int.TryParse(Console.ReadLine(), out length);
            for (int i = 0; i < obj.ArrayMultiples(number, length).Length; i++)
            {
                System.Console.Write($"{obj.ArrayMultiples(number, length)[i]} {" "}");
            }
        }
        public  int[] ArrayMultiples(int number, int length)
        {
            int[] array = new int[length];
            int j = 1;
            for (int i = 0; i < length; i++)
            {
                array[i] = number * j;
                j++;
            }
            return array;
        }
    }

}
