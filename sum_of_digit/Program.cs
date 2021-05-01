using System;

namespace sum_of_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,sum=0,r;
            Console.WriteLine("Enter the number");
            number=int.Parse(Console.ReadLine());
            while(number>0)
            {
                r=number%10;
                sum=sum+r;
                number/=10;
            }
            System.Console.WriteLine($"sum is {sum}");
        }
    }
}
