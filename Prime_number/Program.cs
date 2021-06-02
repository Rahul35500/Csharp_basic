using System;

namespace Prime_number
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number, flag = 0;
            Console.WriteLine("Enter the number to check prime or not ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine("Number is prime ");
                flag = 1;
            }
            if (flag == 0)
            {
                Console.WriteLine("number is not prime");
            }
        }
    }
}
