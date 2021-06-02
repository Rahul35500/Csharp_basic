using System;

namespace SecondProgram
{
    enum months
    {
        janaury=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number for the months");
            int number=int.Parse(Console.ReadLine());
            switch(number)
            {
                case (int)months.janaury:
                {
                    Console.WriteLine("january");
                    break;
                }
                case (int)months.February:
                {
                    System.Console.WriteLine("February");
                    break;
                }
                case (int)months.March:
                {
                    System.Console.WriteLine("march");
                    break;
                }
                case (int)months.April:
                {
                    System.Console.WriteLine("April");
                    break;
                }
                case (int)months.May:
                {
                    System.Console.WriteLine("May");
                    break;
                }
                case (int)months.June:
                {
                    System.Console.WriteLine("June");
                    break;
                }
                case (int)months.July:
                {
                    System.Console.WriteLine("July");
                    break;
                }
                case (int)months.August:
                {
                    System.Console.WriteLine("August");
                    break;
                }
                case (int)months.September:
                {
                    System.Console.WriteLine("September");
                    break;

                }
                case (int)months.October:
                {
                    System.Console.WriteLine("October");
                    break;
                }
                case (int)months.November:
                {
                    System.Console.WriteLine("November");
                    break;
                }
                case (int)months.December:
                {
                    System.Console.WriteLine("December");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Wrong input");
                    break;
                }
            }
            
        }
    }
}
