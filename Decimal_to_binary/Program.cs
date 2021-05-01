using System;

namespace Decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr=new int[10];
            int number,i;
            Console.WriteLine("Enter the number");
            number=int.Parse(Console.ReadLine());
            for(i=0;number>0;i++)
            {
                arr[i]=number%2;
                number=number/2;
            }
            Console.WriteLine("Binary of the given number=");
            for(int j=i-1;j>=0;j--)
            {
                System.Console.Write(arr[j]);
            }

        }
    }
}
