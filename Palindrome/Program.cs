using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp, sum=0, hold_reverse;
            System.Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                hold_reverse = number % 10;
                sum = (sum * 10) + hold_reverse;
                number = number / 10;
            }
            if (sum == temp)
            {
                System.Console.WriteLine("number is palindrome");
            }
            else
            {
                System.Console.WriteLine("number is not palindrome");
            }

        }
    }
}
