using System;

namespace ConvertNumberToCorrespondingMonthName
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number between one and thirteen");
            int number;
            int.TryParse(Console.ReadLine(),out number);
            System.Console.Write($"{number} number in month = {Getname(number)}");


        }
        static string Getname(int month)
        {
            DateTime Month=new DateTime(2020,month,1);
            return Month.ToString("MMMM");
        }
    }
}
