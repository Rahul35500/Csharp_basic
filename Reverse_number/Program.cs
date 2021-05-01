using System;

namespace Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,reverse=0,r;
            Console.WriteLine("Enter the number");
            number=int.Parse(Console.ReadLine());
            while(number>0)
            {
                r=number%10;
                reverse=reverse*10+r; 
                number/=10;
            }
            System.Console.WriteLine($"Reverse number is {reverse}");
        }
    }
}
