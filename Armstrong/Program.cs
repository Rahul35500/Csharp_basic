using System;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp, sum = 0, r;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                r = number % 10;
                sum = sum + (r * r * r);
                number /= 10;
            }
            if (temp == sum)
            {
                System.Console.WriteLine("number is armstrog");
            }
            else
            {
                System.Console.WriteLine("number is not armstrong");
            }
        }
    }
}
